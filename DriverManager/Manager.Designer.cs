
namespace DriverManager
{
    partial class Manager
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
            this.LoadDriver = new System.Windows.Forms.Button();
            this.UnloadDriver = new System.Windows.Forms.Button();
            this.TestSigningOn = new System.Windows.Forms.Button();
            this.TestSigningOff = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // LoadDriver
            // 
            this.LoadDriver.AccessibleName = "LoadDriver_button";
            this.LoadDriver.Location = new System.Drawing.Point(91, 12);
            this.LoadDriver.Name = "LoadDriver";
            this.LoadDriver.Size = new System.Drawing.Size(140, 39);
            this.LoadDriver.TabIndex = 0;
            this.LoadDriver.Text = "Load driver";
            this.LoadDriver.UseVisualStyleBackColor = true;
            this.LoadDriver.Click += new System.EventHandler(this.LoadDriver_Click);
            // 
            // UnloadDriver
            // 
            this.UnloadDriver.Location = new System.Drawing.Point(91, 57);
            this.UnloadDriver.Name = "UnloadDriver";
            this.UnloadDriver.Size = new System.Drawing.Size(140, 39);
            this.UnloadDriver.TabIndex = 1;
            this.UnloadDriver.Text = "Unload driver";
            this.UnloadDriver.UseVisualStyleBackColor = true;
            this.UnloadDriver.Click += new System.EventHandler(this.UnloadDriver_Click);
            // 
            // TestSigningOn
            // 
            this.TestSigningOn.Location = new System.Drawing.Point(91, 102);
            this.TestSigningOn.Name = "TestSigningOn";
            this.TestSigningOn.Size = new System.Drawing.Size(140, 39);
            this.TestSigningOn.TabIndex = 2;
            this.TestSigningOn.Text = "Test signing on";
            this.TestSigningOn.UseVisualStyleBackColor = true;
            this.TestSigningOn.Click += new System.EventHandler(this.TestSigningOn_Click);
            // 
            // TestSigningOff
            // 
            this.TestSigningOff.Location = new System.Drawing.Point(91, 147);
            this.TestSigningOff.Name = "TestSigningOff";
            this.TestSigningOff.Size = new System.Drawing.Size(140, 39);
            this.TestSigningOff.TabIndex = 3;
            this.TestSigningOff.Text = "Test signing off";
            this.TestSigningOff.UseVisualStyleBackColor = true;
            this.TestSigningOff.Click += new System.EventHandler(this.TestSigningOff_Click);
            // 
            // Manager
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(330, 200);
            this.Controls.Add(this.TestSigningOff);
            this.Controls.Add(this.TestSigningOn);
            this.Controls.Add(this.UnloadDriver);
            this.Controls.Add(this.LoadDriver);
            this.Name = "Manager";
            this.Text = "DriverManager";
            this.Load += new System.EventHandler(this.Manager_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button LoadDriver;
        private System.Windows.Forms.Button UnloadDriver;
        private System.Windows.Forms.Button TestSigningOn;
        private System.Windows.Forms.Button TestSigningOff;
    }
}

