namespace GuptaTool.Forms
{
 partial class MainForm
 {
  /// <summary>
  /// Required designer variable.
  /// </summary>
  private System.ComponentModel.IContainer components = null;

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
   System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
   this.menuStrip1 = new System.Windows.Forms.MenuStrip();
   this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
   this.openToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
   this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
   this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
   this.groupBox1 = new System.Windows.Forms.GroupBox();
   this.label1 = new System.Windows.Forms.Label();
   this.txtColumnQuery = new System.Windows.Forms.TextBox();
   this.groupBox2 = new System.Windows.Forms.GroupBox();
   this.txtResult = new System.Windows.Forms.TextBox();
   this.label2 = new System.Windows.Forms.Label();
   this.txtQueryCollumnDetail = new System.Windows.Forms.TextBox();
   this.treeStructure = new System.Windows.Forms.TreeView();
   this.menuStrip1.SuspendLayout();
   this.groupBox1.SuspendLayout();
   this.groupBox2.SuspendLayout();
   this.SuspendLayout();
   // 
   // menuStrip1
   // 
   this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.helpToolStripMenuItem});
   this.menuStrip1.Location = new System.Drawing.Point(0, 0);
   this.menuStrip1.Name = "menuStrip1";
   this.menuStrip1.Size = new System.Drawing.Size(949, 24);
   this.menuStrip1.TabIndex = 0;
   this.menuStrip1.Text = "menuStrip1";
   // 
   // fileToolStripMenuItem
   // 
   this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.openToolStripMenuItem});
   this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
   this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
   this.fileToolStripMenuItem.Text = "File";
   // 
   // openToolStripMenuItem
   // 
   this.openToolStripMenuItem.Name = "openToolStripMenuItem";
   this.openToolStripMenuItem.Size = new System.Drawing.Size(103, 22);
   this.openToolStripMenuItem.Text = "Open";
   this.openToolStripMenuItem.Click += new System.EventHandler(this.openToolStripMenuItem_Click);
   // 
   // helpToolStripMenuItem
   // 
   this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutToolStripMenuItem});
   this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
   this.helpToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
   this.helpToolStripMenuItem.Text = "Help";
   // 
   // aboutToolStripMenuItem
   // 
   this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
   this.aboutToolStripMenuItem.Size = new System.Drawing.Size(107, 22);
   this.aboutToolStripMenuItem.Text = "About";
   this.aboutToolStripMenuItem.Click += new System.EventHandler(this.aboutToolStripMenuItem_Click);
   // 
   // groupBox1
   // 
   this.groupBox1.Controls.Add(this.label2);
   this.groupBox1.Controls.Add(this.txtQueryCollumnDetail);
   this.groupBox1.Controls.Add(this.label1);
   this.groupBox1.Controls.Add(this.txtColumnQuery);
   this.groupBox1.Location = new System.Drawing.Point(270, 27);
   this.groupBox1.Name = "groupBox1";
   this.groupBox1.Size = new System.Drawing.Size(667, 122);
   this.groupBox1.TabIndex = 1;
   this.groupBox1.TabStop = false;
   this.groupBox1.Text = "Search";
   // 
   // label1
   // 
   this.label1.AutoSize = true;
   this.label1.Location = new System.Drawing.Point(6, 16);
   this.label1.Name = "label1";
   this.label1.Size = new System.Drawing.Size(125, 13);
   this.label1.TabIndex = 1;
   this.label1.Text = "Search for column name:";
   // 
   // txtColumnQuery
   // 
   this.txtColumnQuery.Location = new System.Drawing.Point(5, 35);
   this.txtColumnQuery.Name = "txtColumnQuery";
   this.txtColumnQuery.Size = new System.Drawing.Size(655, 20);
   this.txtColumnQuery.TabIndex = 0;
   this.txtColumnQuery.TextChanged += new System.EventHandler(this.txtColumnQuery_TextChanged);
   // 
   // groupBox2
   // 
   this.groupBox2.Controls.Add(this.txtResult);
   this.groupBox2.Location = new System.Drawing.Point(270, 155);
   this.groupBox2.Name = "groupBox2";
   this.groupBox2.Size = new System.Drawing.Size(667, 450);
   this.groupBox2.TabIndex = 2;
   this.groupBox2.TabStop = false;
   this.groupBox2.Text = "Result";
   // 
   // txtResult
   // 
   this.txtResult.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
   this.txtResult.Location = new System.Drawing.Point(6, 19);
   this.txtResult.Multiline = true;
   this.txtResult.Name = "txtResult";
   this.txtResult.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
   this.txtResult.Size = new System.Drawing.Size(655, 425);
   this.txtResult.TabIndex = 0;
   // 
   // label2
   // 
   this.label2.AutoSize = true;
   this.label2.Location = new System.Drawing.Point(6, 67);
   this.label2.Name = "label2";
   this.label2.Size = new System.Drawing.Size(89, 13);
   this.label2.TabIndex = 3;
   this.label2.Text = "Get column detail";
   // 
   // txtQueryCollumnDetail
   // 
   this.txtQueryCollumnDetail.Location = new System.Drawing.Point(5, 86);
   this.txtQueryCollumnDetail.Name = "txtQueryCollumnDetail";
   this.txtQueryCollumnDetail.Size = new System.Drawing.Size(655, 20);
   this.txtQueryCollumnDetail.TabIndex = 2;
   this.txtQueryCollumnDetail.TextChanged += new System.EventHandler(this.txtQueryCollumnDetail_TextChanged);
   // 
   // treeStructure
   // 
   this.treeStructure.Location = new System.Drawing.Point(12, 27);
   this.treeStructure.Name = "treeStructure";
   this.treeStructure.Size = new System.Drawing.Size(252, 572);
   this.treeStructure.TabIndex = 3;
   this.treeStructure.NodeMouseDoubleClick += new System.Windows.Forms.TreeNodeMouseClickEventHandler(this.treeStructure_NodeMouseDoubleClick);
   // 
   // MainForm
   // 
   this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
   this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
   this.ClientSize = new System.Drawing.Size(949, 617);
   this.Controls.Add(this.treeStructure);
   this.Controls.Add(this.groupBox2);
   this.Controls.Add(this.groupBox1);
   this.Controls.Add(this.menuStrip1);
   this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
   this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
   this.MainMenuStrip = this.menuStrip1;
   this.MaximizeBox = false;
   this.Name = "MainForm";
   this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
   this.Text = "Gupta Tool";
   this.menuStrip1.ResumeLayout(false);
   this.menuStrip1.PerformLayout();
   this.groupBox1.ResumeLayout(false);
   this.groupBox1.PerformLayout();
   this.groupBox2.ResumeLayout(false);
   this.groupBox2.PerformLayout();
   this.ResumeLayout(false);
   this.PerformLayout();

  }

  #endregion

  private System.Windows.Forms.MenuStrip menuStrip1;
  private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
  private System.Windows.Forms.ToolStripMenuItem openToolStripMenuItem;
  private System.Windows.Forms.GroupBox groupBox1;
  private System.Windows.Forms.GroupBox groupBox2;
  private System.Windows.Forms.TextBox txtResult;
  private System.Windows.Forms.TextBox txtColumnQuery;
  private System.Windows.Forms.Label label1;
  private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
  private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
  private System.Windows.Forms.Label label2;
  private System.Windows.Forms.TextBox txtQueryCollumnDetail;
  private System.Windows.Forms.TreeView treeStructure;
 }
}