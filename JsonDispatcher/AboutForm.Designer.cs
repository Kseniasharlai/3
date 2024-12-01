using System.ComponentModel;

namespace JsonDispatcher;

partial class AboutForm
{
    private System.Windows.Forms.Label lblAboutInfo;
    
    private IContainer components = null;

    /// <summary>
    /// Clean up any resources being used.
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
    /// Required method for Designer support - do not modify
    /// the contents of this method with the code editor.
    /// </summary>
    private void InitializeComponent()
    {
        this.lblAboutInfo = new System.Windows.Forms.Label();
        this.SuspendLayout();

        this.lblAboutInfo.AutoSize = true;
        this.lblAboutInfo.Location = new System.Drawing.Point(13, 13);
        this.lblAboutInfo.Name = "lblAboutInfo";
        this.lblAboutInfo.Size = new System.Drawing.Size(35, 13);
        this.lblAboutInfo.TabIndex = 0;
        this.lblAboutInfo.Text = "About";

        this.ClientSize = new System.Drawing.Size(284, 261);
        this.Controls.Add(this.lblAboutInfo);
        this.Name = "AboutForm";
        this.ResumeLayout(false);
        this.PerformLayout();
    }

    #endregion
}