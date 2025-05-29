using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Microsoft.VisualBasic;

namespace andersKPasswordChecker
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnValidatePassword_Click(object sender, EventArgs e)
        {
            //Variables
            int intRequiredPassLen; //change to a try parse
            int intActualPassLen;
            string strPass;
            char chrPassChar = ' ';
            int intASCILLVal;

            bool blnhasLowerCase = false;
            bool blnhasUpperCase = false;
            bool blnhasNum = false;
            bool blnhasSpChar = false;
            bool blnhasSpace = false;

            //clear password results
            lstPasswordResults.Items.Clear();
            //clear picBoxs
            picCharNumCorrect.Visible = false;
            picCharNumIncorrect.Visible = false;
            picLowerCaseCharCorrect.Visible = false;
            picLowerCaseCharIncorrect.Visible = false;
            picNumCorrect.Visible = false;
            picNumIncorrect.Visible = false;
            picSpCharCorrect.Visible = false;
            picSpCharIncorrect.Visible = false;
            picUpperCaseCharCorrect.Visible = false;
            picUpperCaseCharIncorrect.Visible = false;

            //Check min password length
            int.TryParse(txtPasswordLength.Text, out intRequiredPassLen);
            if (intRequiredPassLen >= 4)
            {
                lblCharNum.Text = "Has " + intRequiredPassLen + "+ Characters";
                strPass = txtEnterPassword.Text;
                intActualPassLen = strPass.Length;
                // do while to get password if length is < required use input box to get new password
                while (intActualPassLen < intRequiredPassLen) {
                    strPass = Interaction.InputBox("Please Enter a Password of " + intRequiredPassLen + " characters or more");
                    intActualPassLen = strPass.Length;
                    txtEnterPassword.Text = strPass;
                }
                /* if actual password is >= required password
                 * use a for loop to interate the password str
                 * get char at x
                 * convert char to ascii
                 * trip bool flags
                 * add to listbox
                 */
                for (int i = 0; i < intActualPassLen; i++)
                {
                    // get char and its ascii
                    chrPassChar = strPass[i];
                    intASCILLVal = (int)chrPassChar;

                    // checks if there is a space
                    if (intASCILLVal == 32)
                    {
                        blnhasSpace = true;
                    }
                
                    // bool flags
                    if ((intASCILLVal >= 97) && (intASCILLVal <= 122)) 
                    {
                        blnhasLowerCase = true;
                    }
                    else if ((intASCILLVal >= 65) && (intASCILLVal <= 90))
                    {
                        blnhasUpperCase = true;
                    }
                    else if ((intASCILLVal >= 48) && (intASCILLVal <= 57))
                    {
                        blnhasNum = true;
                    }
                    else if (((intASCILLVal >= 33) && (intASCILLVal <= 125)))
                    {
                        blnhasSpChar = true;
                    }

                    // add char to password list
                    lstPasswordResults.Items.Add(
                        "Postion " +
                        i +
                        " is " +
                        chrPassChar +
                        " with ASCII Value " +
                        intASCILLVal);
                }
                if (blnhasSpace)
                {
                    // displays message box then clears txtbox that gets the password
                    MessageBox.Show("Space is NOT a Vaild Special Character");
                    txtEnterPassword.Text = "";
                }
                else {
                    // shows check or x if pswd has correct amount of chars
                    if (intActualPassLen >= intRequiredPassLen)
                    {
                        picCharNumCorrect.Visible = true;
                    }
                    else
                    {
                        picCharNumIncorrect.Visible = true;
                    }
                    // shows check or x if pswd has a lower case char
                    if (blnhasLowerCase)
                    {
                        picLowerCaseCharCorrect.Visible = true;
                    }
                    else
                    {
                        picLowerCaseCharIncorrect.Visible = true;
                    }
                    // shows check or x if pswd has a upper case char
                    if (blnhasUpperCase)
                    {
                        picUpperCaseCharCorrect.Visible = true;
                    }
                    else
                    {
                        picUpperCaseCharIncorrect.Visible = true;
                    }
                    //shows check or x if pswd has a num
                    if (blnhasNum)
                    {
                        picNumCorrect.Visible = true;
                    }
                    else
                    {
                        picNumIncorrect.Visible = true;
                    }
                    //shows check or x if pswd has a special char
                    if (blnhasSpChar)
                    {
                        picSpCharCorrect.Visible = true;
                    }
                    else
                    {
                        picSpCharIncorrect.Visible = true;
                    }
                } 
            }
            else {
                MessageBox.Show("Please Enter a Minimum Password Length of 4");
            }
            
        }

        private void btnGenerate_Click(object sender, EventArgs e)
        {
            //variables
            string strPass = "";
            char chrPassChar = ' ';
            int intASCILLVal;
            int intAcutalPassLen;
            int.TryParse(txtPasswordLength.Text,out intAcutalPassLen);
            bool blnLowerCase = false;
            int i = 3;
            //create random object
            Random rand = new Random();

            //generates uppercase letter
            intASCILLVal = rand.Next(65,90);
            chrPassChar = (char)intASCILLVal;
            strPass += chrPassChar;

            //generates number
            intASCILLVal = rand.Next(48, 57);
            chrPassChar = (char)intASCILLVal;
            strPass += chrPassChar;

            //generates speical character
            switch(rand.Next(1,4)){
                case 1:
                    intASCILLVal = rand.Next(33, 47);
                    break;
                case 2:
                    intASCILLVal = rand.Next(58, 64);
                    break;
                case 3:
                    intASCILLVal = rand.Next(91, 96);
                    break;
                case 4:
                    intASCILLVal = rand.Next(123, 126);
                    break;
            }
            chrPassChar = (char)intASCILLVal;
            strPass += chrPassChar;

            //while loop to fill the rest
            while (!blnLowerCase || (intAcutalPassLen > strPass.Length)) {
                switch (rand.Next(1, 4)) { 
                    //lower case
                    case 1:
                        intASCILLVal = rand.Next(97, 122);
                        break;
                    // upper case
                    case 2:
                        intASCILLVal = rand.Next(65, 90);
                        break;
                    // number
                    case 3:
                        intASCILLVal = rand.Next(48, 57);
                        break;
                    //sp char
                    case 4:
                        switch (rand.Next(1, 4))
                        {
                            case 1:
                                intASCILLVal = rand.Next(33, 47);
                                break;
                            case 2:
                                intASCILLVal = rand.Next(58, 64);
                                break;
                            case 3:
                                intASCILLVal = rand.Next(91, 96);
                                break;
                            case 4:
                                intASCILLVal = rand.Next(123, 126);
                                break;
                        }
                        break;
                }
                chrPassChar = (char)intASCILLVal;
                strPass += chrPassChar;
                txtEnterPassword.Text = strPass;
                if ((intASCILLVal >= 97) && (intASCILLVal <= 122))
                {
                    blnLowerCase = true;
                }            
            } 
        } 
    }
}
