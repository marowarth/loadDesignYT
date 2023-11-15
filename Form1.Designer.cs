namespace loadDesignYT
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            userBox = new TextBox();
            passBox = new TextBox();
            userLabel = new Label();
            passLabel = new Label();
            accesButton = new Button();
            panelNavBar = new Panel();
            title = new Label();
            exit = new Button();
            backgroundAnimated = new PictureBox();
            panelNavBar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)backgroundAnimated).BeginInit();
            SuspendLayout();
            // 
            // userBox
            // 
            userBox.BackColor = Color.Black;
            userBox.BorderStyle = BorderStyle.None;
            userBox.Font = new Font("Showcard Gothic", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            userBox.ForeColor = Color.LavenderBlush;
            userBox.Location = new Point(288, 161);
            userBox.Name = "userBox";
            userBox.PlaceholderText = "USUARIO";
            userBox.Size = new Size(245, 24);
            userBox.TabIndex = 0;
            // 
            // passBox
            // 
            passBox.BackColor = Color.Black;
            passBox.BorderStyle = BorderStyle.None;
            passBox.Font = new Font("Showcard Gothic", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            passBox.ForeColor = Color.LavenderBlush;
            passBox.Location = new Point(288, 217);
            passBox.Name = "passBox";
            passBox.PasswordChar = '*';
            passBox.PlaceholderText = "PASSWORD";
            passBox.Size = new Size(245, 24);
            passBox.TabIndex = 1;
            // 
            // userLabel
            // 
            userLabel.AutoSize = true;
            userLabel.BackColor = Color.Transparent;
            userLabel.Font = new Font("Showcard Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point);
            userLabel.ForeColor = Color.LavenderBlush;
            userLabel.Location = new Point(289, 133);
            userLabel.Name = "userLabel";
            userLabel.Size = new Size(61, 15);
            userLabel.TabIndex = 2;
            userLabel.Text = "USUARIO";
            // 
            // passLabel
            // 
            passLabel.AutoSize = true;
            passLabel.BackColor = Color.Transparent;
            passLabel.Font = new Font("Showcard Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point);
            passLabel.ForeColor = Color.LavenderBlush;
            passLabel.Location = new Point(288, 193);
            passLabel.Name = "passLabel";
            passLabel.Size = new Size(75, 15);
            passLabel.TabIndex = 3;
            passLabel.Text = "PASSWORD";
            // 
            // accesButton
            // 
            accesButton.BackColor = Color.Black;
            accesButton.FlatStyle = FlatStyle.Flat;
            accesButton.Font = new Font("Showcard Gothic", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            accesButton.ForeColor = Color.LavenderBlush;
            accesButton.Location = new Point(289, 275);
            accesButton.Name = "accesButton";
            accesButton.Size = new Size(244, 32);
            accesButton.TabIndex = 4;
            accesButton.Text = "iniciar sesión";
            accesButton.UseVisualStyleBackColor = false;
            // 
            // panelNavBar
            // 
            panelNavBar.BackColor = Color.Black;
            panelNavBar.Controls.Add(title);
            panelNavBar.Controls.Add(exit);
            panelNavBar.Location = new Point(0, -4);
            panelNavBar.Name = "panelNavBar";
            panelNavBar.Size = new Size(800, 52);
            panelNavBar.TabIndex = 5;
            // 
            // title
            // 
            title.AutoSize = true;
            title.Font = new Font("Showcard Gothic", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            title.ForeColor = Color.LavenderBlush;
            title.Location = new Point(12, 13);
            title.Name = "title";
            title.Size = new Size(119, 27);
            title.TabIndex = 1;
            title.Text = "LOGIN PRO";
            // 
            // exit
            // 
            exit.FlatAppearance.BorderSize = 0;
            exit.FlatStyle = FlatStyle.Flat;
            exit.Font = new Font("Showcard Gothic", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            exit.ForeColor = Color.IndianRed;
            exit.Location = new Point(740, 6);
            exit.Name = "exit";
            exit.Size = new Size(60, 46);
            exit.TabIndex = 0;
            exit.Text = "X";
            exit.UseVisualStyleBackColor = true;
            exit.Click += button1_Click;
            // 
            // backgroundAnimated
            // 
            backgroundAnimated.BackColor = Color.Transparent;
            backgroundAnimated.Image = Properties.Resources.chain___25380__1080p_;
            backgroundAnimated.Location = new Point(0, 47);
            backgroundAnimated.Name = "backgroundAnimated";
            backgroundAnimated.Size = new Size(800, 404);
            backgroundAnimated.SizeMode = PictureBoxSizeMode.StretchImage;
            backgroundAnimated.TabIndex = 6;
            backgroundAnimated.TabStop = false;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(panelNavBar);
            Controls.Add(accesButton);
            Controls.Add(passLabel);
            Controls.Add(userLabel);
            Controls.Add(passBox);
            Controls.Add(userBox);
            Controls.Add(backgroundAnimated);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Form1";
            Text = "LOGIN";
            panelNavBar.ResumeLayout(false);
            panelNavBar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)backgroundAnimated).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        private void tranparentLocation(Label label, PictureBox pictureBox)
        {
            label.Location = pictureBox.PointToClient(this.PointToScreen(label.Location));
            label.Parent = pictureBox;
        }

        #endregion

        private TextBox userBox;
        private TextBox passBox;
        private Label userLabel;
        private Label passLabel;
        private Button accesButton;
        private Panel panelNavBar;
        private Label title;
        private Button exit;
        private PictureBox backgroundAnimated;
    }
}