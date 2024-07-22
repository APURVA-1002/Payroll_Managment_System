using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PayrollMngmentSystem
{
    public partial class BaseForm : Form
    {
        public BaseForm()
        {
            InitializeComponent();
        }
        public void ClearControls(Control FocusControl, Control.ControlCollection ctrl, bool ClearFocusControl = true)
        {
            string FocusControlValue = "";
            if (!ClearFocusControl)
            {
                FocusControlValue = FocusControl.Text;
            }
            foreach (Control item in ctrl)
            {
                if (item.Tag != null)
                    item.Text = "";
                else if (item.GetType().Name == "ComboBox")
                {
                    ComboBox cmb = (ComboBox)item;
                    cmb.SelectedIndex = 0;
                }
                else if (item.GetType().Name == "DateTimePicker")
                {
                    DateTimePicker dtm = (DateTimePicker)item;
                    dtm.Value = DateTime.Now;
                }
                else if(item.GetType().Name=="TextBox")
                {
                    TextBox txt = (TextBox)item;
                    txt.Text= string.Empty;
                }
            }
            if (!ClearFocusControl)
                FocusControl.Text = FocusControlValue;
            FocusControl.Focus();
        }
        public void Control_KeyPress(object sender, KeyPressEventArgs e)
        {
            Control ctrl = (Control)sender;

            string validstr = "abcdefghijklmnopqrstuvwxyz \b@-/";

            //Navigating the form using enter and escape
            if (e.KeyChar == 13)
            {
                SendKeys.Send("{TAB}");
            }
            else if (e.KeyChar == 27)
            {
                SendKeys.Send("+{TAB}");
            }

            if (ctrl.Tag != null && ctrl.Tag == "int")
            {
                if (!(e.KeyChar >= '0' && e.KeyChar <= '9' || e.KeyChar == '\b'))
                    e.KeyChar = (char)0;
            }
            else if (ctrl.Tag != null && ctrl.Tag == "string")
            {
                if (!validstr.Contains(e.KeyChar.ToString().ToLower()))
                    e.KeyChar = (char)0;

                if (ctrl.Text.Split(' ').Length > 2 && e.KeyChar == ' ')
                    e.KeyChar = (char)0;

                if (ctrl.Text.Length > 0 && ctrl.Text.Substring(ctrl.Text.Length - 1) == " " && e.KeyChar == ' ')
                    e.KeyChar = (char)0;
            }
            else if (ctrl.Tag != null && ctrl.Tag == "double")
            {
                if (!(e.KeyChar >= '0' && e.KeyChar <= '9' || e.KeyChar == '\b' || e.KeyChar == '.'))
                    e.KeyChar = (char)0;

                if (ctrl.Text.Contains('.') && e.KeyChar == '.')
                    e.KeyChar = (char)0;

                int dotpos = ctrl.Text.IndexOf(".");

                if (dotpos >= 0 && e.KeyChar == '\b')
                {
                    if (ctrl.Text.Substring(dotpos).Length > 2)
                        e.KeyChar = (char)0;
                }
            }
            else if (ctrl.Tag != null && ctrl.Tag == "email")
            {
                string emailChars = "abcdefghijklmnopqrstuvwxyz0123456789.-_@\b";

                if (!emailChars.Contains(e.KeyChar.ToString().ToLower()))
                    e.KeyChar = (char)0;
                if (e.KeyChar == '@' && ctrl.Text.Contains('@'))
                    e.KeyChar = (char)0; // Allow only one '@' symbol
                else if (e.KeyChar == '.' && ctrl.Text.Contains('@') && ctrl.Text.Split('@')[1].Contains('.'))
                    e.KeyChar = (char)0; // Allow only one dot in the domain part
                else if (e.KeyChar == '.' && ctrl.Text.EndsWith("."))
                    e.KeyChar = (char)0; // Avoid trailing dot in the email address
            }
            else if (ctrl.Tag != null && ctrl.Tag == "city")
            {
                string validCityChars = "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ-'\b";

                if (!validCityChars.Contains(e.KeyChar.ToString().ToLower()))
                    e.KeyChar = (char)0;
            }
        }
    }
}
