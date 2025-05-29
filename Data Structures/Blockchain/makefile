all: block blockchain
	g++ -pedantic-errors -g main.cpp block blockchain
blockchain: block chain.h blockChain.cpp
	g++ -pedantic-errors -g -c blockChain.cpp -o blockchain
block: block.h block.cpp
	g++ -pedantic-errors -g -c block.cpp -o block

clean:
	rm a.out