/*
*
*   This program is to emulate how a 6502 CPU functions
*
*/

#include <stdio.h>
#include <stdlib.h>

using Byte = unsigned char;
using Word = unsigned short;
using u32 = unsigned int;

struct Memory{
    static constexpr u32 MAX_MEM = 1024 * 64;
    Byte Data[MAX_MEM];

    void Initialise(){
        // Initalises the Data in Memory to 0
        for(u32 i = 0; i < MAX_MEM; i++){
            Data[i] = 0;
        }
    }
    // read 1 byte
    Byte operator[](u32 Address) const{
        // assert here Address is < MAX_MEM
        return Data[Address];
    }

    // write 1 byte
    Byte& operator[](u32 Address){
        // assert here Address is < MAX_MEM
        return Data[Address];
    }

    // write 2 bytes
    void WriteWord(Word Value, u32 Address, u32& cycles){
        Data[Address] = Value & 0xFF;
        Data[Address + 1] = (Value >> 8);
        cycles -= 2;
    }
};

struct CPU{
    // Program counter (in CPU)
    Word PC;

    // Stack Pointer (in CPU)
    Word SP;

    // Accmulator (in CPU) / Index Register X / Index Register Y
    Byte A, X, Y;

    /// Bits in the Processor Status
    // Cary flag
    Byte C : 1;
    // Zero Flag
    Byte Z : 1;
    // Interupt Disable
    Byte I : 1;
    // Decimal Mode
    Byte D : 1;
    // Break Command
    Byte B : 1;
    // Overflow Flag
    Byte V : 1;
    // Negative Flag
    Byte N : 1;

    void Reset(Memory& memory){
        // Rests the CPU the default values and memory locations
        PC = 0xFFFC;
        SP = 0x0100;
        C = Z = I = D = B = V = N = 0;
        A = X = Y = 0;
        memory.Initialise();
    }

    Byte FetchByte(u32& cycles, Memory& memory){
        // Fetches byte that it is given from Execute
        Byte Data = memory[PC];
        PC++;
        cycles--;
        return Data;
    }

    Word FetchWord(u32& cycles, Memory& memory){
        // Fetches word that it is given from Execute
        // 6502 is little endian
        Word Data = memory[PC];
        PC++;

        // shift the memory loction by 8 bytes and xor it to data
        Data |= (memory[PC] << 8);
        PC++;
        cycles -= 2;
        return Data;

        // if you wanted to handle endianness
        // you would have to sawp bytes here
        // if (PLATFORM_BIG_ENDIAN)
        // SwapBytesInWord(Data)
    }

    Byte ReadByte(u32& cycles, Byte Address, Memory& memory){
        // Reads byte that it is given from Execute
        Byte Data = memory[Address];
        cycles--;
        return Data;
    }
    // opcodes
    // Instruction Load Accumulator Immediate = $A9
    // Instruction Load Accumulator Zero Page = $A5
    // Instruction Load Accumulator Zero Page X = $B5
    // Instruction Jump to Subroutine = $20 
    static constexpr Byte 
        INS_LDA_IM = 0xA9,
        INS_LDA_ZP = 0xA5,
        INS_LDA_ZPX = 0xB5,
        INS_JSR = 0x20;

    void LDASetStatus(){
        // Set bit if A = 0
        Z = (A == 0);
        // Set bit if & of A is set
        N = (A & 0b10000000) > 0;
    }

    void Execute(u32 cycles, Memory& memory){
        // Executes a command given to the CPU
        while( cycles > 0){
            Byte Instuction = FetchByte(cycles, memory);
            switch(Instuction){
                case INS_LDA_IM:{
                    Byte Value = FetchByte(cycles, memory);
                    A = Value;
                    LDASetStatus();
                } break;

                case INS_LDA_ZP:{
                    Byte ZeroPageAddress = FetchByte(cycles, memory);
                    A = ReadByte(cycles, ZeroPageAddress, memory);
                    LDASetStatus();
                }break;

                case INS_LDA_ZPX:{
                    Byte ZeroPageAddress = FetchByte(cycles, memory);
                    ZeroPageAddress += X;
                    cycles--;
                    A = ReadByte(cycles, ZeroPageAddress, memory);
                    LDASetStatus();
                }break;

                case INS_JSR:{
                    Word SubroutineAddr = FetchWord(cycles, memory);
                    memory.WriteWord(PC - 1, SP, cycles);
                    PC = SubroutineAddr;
                    cycles--;
                }break;

                default:{
                    printf("Instruction not Handled %d", Instuction);
                } break;
            }
        }
    }
};

int main(){
    Memory memory;
    CPU cpu;
    cpu.Reset(memory);
    // start - inline a little program 
    memory[0xFFFC] = CPU::INS_LDA_ZP;
    memory[0xFFFD] = 0x42;
    memory[0x0042] = 0x84;
    // end = inline a little program
    cpu.Execute(3,memory);

    return 0;
}