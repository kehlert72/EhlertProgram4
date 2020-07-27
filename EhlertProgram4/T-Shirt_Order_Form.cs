using System;
using System.Windows.Forms;

/*  ID
 *      T-Shirt Order Form, Kaleb Ehlert, 2/4/2018
 *  Purpose
 *      The purpose of the program is to take the info of the customer along with the size and quantity of the shirt the user wants and output the info line-by-line.
 *  Form Controls
 *      Submission: lblInfo: Labels the listbox asking for info on the customer,    lstInfo: Labels the info wanted by the customer,    txtName: Captures the name of the
 *      user in the textbox,    txtEmail: Captures the email of the user in the textbox,    txtPhone: Captures the phone number of the user in the textbox,
 *      lblSize: Labels the check list size,   lstSize: Allows for the user to pick a size for the t-shirt, lblQuantity: Labels the quantity combo box, cboQuantity:
 *      Allows the user to pick a desired quantity, lblOrderInfo: Labels the text box OrderInfo,    txtOrderInfo: Displays all of the information the user has entered,
 *      mnuItemDisplayOrder: When clicked the menu item will process the order and output the input that was processed, mnuItemExit: A menu item that will exit the program.
 *  Code & Logic
 *      The name, phone number, email, size, and quantity is needed for input from the user.
 *      The processing is taking the input from the user and setting it in a string. Each input is set on it's own line.
 *      The output is the multiline text box getting the string and display that string. The result is the information being displayed line-by-line.
 */

namespace EhlertProgram4
{
    public partial class frmTshirtOrder : Form
    {
        public frmTshirtOrder()
        {
            InitializeComponent();
        }

        // The event for DisplayOrder when triggered will collect all data the user has given and display that information.
        //This is the method it calls on.
        private void displayOrderToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Empty the text from the order info
            txtOrderInfo.Text = "";

            // Get the name, phone number, and email
            txtOrderInfo.Text += txtName.Text + "\r\n" + txtPhone.Text + "\r\n" + txtEmail.Text + "\r\n";

            // Get the size
            txtOrderInfo.Text += ckLstSize.Text + "\r\n";

            // Get the quantity
            txtOrderInfo.Text += cboQuantity.Text + "\r\n";
        }

        // The event for Exit when triggered will end the program.
        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
