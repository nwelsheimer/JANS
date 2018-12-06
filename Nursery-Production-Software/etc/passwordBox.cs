using System.Windows.Forms;
using System.Drawing;

namespace Nursery_Production_Software.etc
{
  class passwordBox
  {
    private Form frm;
    private bool _confirm;
    private int _length;

    private System.Windows.Forms.TextBox password1 { get; set; }
    private System.Windows.Forms.TextBox password2 { get; set; }

    /// <summary>
    /// A simple password dialog prompt that returns the password as a string.
    /// </summary>
    /// <param name="prompt">Prompting text for the first label in the box</param>
    /// <param name="title">Text for the title of the box</param>
    /// <param name="confirm">Require the user to confirm the password by entering it twice</param>
    /// <param name="blowfish">Return the password encrypted with Blowfish algorithm</param>
    public string Show(string prompt, string title, bool confirm, bool blowfish=false, int length = 6)
    {
      frm = new Form();
      FlowLayoutPanel FL = new FlowLayoutPanel();
      Label lbl = new Label();
      Label lbl2 = new Label();
      password1 = new TextBox();
      password2 = new TextBox();
      Button ok = new Button();
      Button cancel = new Button();
      _confirm = confirm;
      _length = length;

      frm.Font = new Font("Calibri", 9, FontStyle.Bold);
      frm.FormBorderStyle = FormBorderStyle.FixedToolWindow;
      frm.StartPosition = FormStartPosition.CenterScreen;
      frm.Width = 200;
      frm.Height = confirm ? 220 : 150;

      frm.Text = title;
      lbl.Text = prompt;
      lbl2.Text = "Confirm password";
      ok.Text = "Ok";
      cancel.Text = "Cancel";
      password1.PasswordChar = '*';
      password2.PasswordChar = '*';

      ok.FlatStyle = FlatStyle.Flat;
      ok.BackColor = SystemColors.ButtonShadow;
      ok.ForeColor = SystemColors.ButtonHighlight;
      ok.Cursor = Cursors.Hand;

      cancel.FlatStyle = FlatStyle.Flat;
      cancel.BackColor = SystemColors.ButtonShadow;
      cancel.ForeColor = SystemColors.ButtonHighlight;
      cancel.Cursor = Cursors.Hand;

      FL.Left = 0;
      FL.Top = 0;
      FL.Width = frm.Width;
      FL.Height = frm.Height;
      FL.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right | AnchorStyles.Top;
      FL.Padding = new Padding(10);
      FL.FlowDirection = FlowDirection.TopDown;

      password1.Width = password2.Width = cancel.Width = lbl.Width = ok.Width = FL.Width - 35;

      ok.Click += new System.EventHandler(okClick);
      cancel.Click += new System.EventHandler(cancelClick);
      password1.KeyPress += new KeyPressEventHandler(txtEnter);
      password2.KeyPress += new KeyPressEventHandler(txtEnter);

      FL.Controls.Add(lbl);
      FL.Controls.Add(password1);
      if (confirm)
      {
        FL.Controls.Add(lbl2);
        FL.Controls.Add(password2);
      }
      FL.Controls.Add(ok);
      FL.Controls.Add(cancel);
      frm.Controls.Add(FL);

      frm.ShowDialog();
      DialogResult DR = frm.DialogResult;
      frm.Dispose();
      frm = null;
      if (DR == DialogResult.OK)
      {
        if (blowfish)
          return BCrypt.Net.BCrypt.HashPassword(password1.Text);
        else
          return password1.Text;
      }
      else
      {
        return "";
      }
    }
    private void okClick(object sender, System.EventArgs e)
    {
      if (_confirm && password1.Text != password2.Text)
      {
        MessageBox.Show("Passwords do not match");
        password1.Text = "";
        password2.Text = "";
        password1.Focus();
      }
      else if (password1.Text.Length < _length)
        {
        MessageBox.Show("Passwords must be at least " + _length.ToString() + " characters long.");
        password1.Text = "";
        password2.Text = "";
        password1.Focus();
      } else
      {
        frm.DialogResult = DialogResult.OK;
        frm.Close();
      }
    }
    private void cancelClick(object sender, System.EventArgs e)
    {
      frm.DialogResult = DialogResult.Cancel;
      frm.Close();
    }
    private void txtEnter(object sender, KeyPressEventArgs e)
    {
      if (e.KeyChar == 13) { okClick(null, null); }
    }
  }
}
