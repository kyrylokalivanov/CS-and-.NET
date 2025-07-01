namespace Final
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
            treeView1 = new TreeView();
            listView1 = new ListView();
            bntAdd = new Button();
            btnEdit = new Button();
            btnDelete = new Button();
            SuspendLayout();
            // 
            // treeView1
            // 
            treeView1.Location = new Point(29, 50);
            treeView1.Name = "treeView1";
            treeView1.Size = new Size(387, 121);
            treeView1.TabIndex = 0;
            treeView1.AfterSelect += treeView1_AfterSelect;
            // 
            // listView1
            // 
            listView1.Location = new Point(443, 50);
            listView1.Name = "listView1";
            listView1.Size = new Size(363, 121);
            listView1.TabIndex = 1;
            listView1.UseCompatibleStateImageBehavior = false;
            listView1.SelectedIndexChanged += listView1_SelectedIndexChanged;
            // 
            // bntAdd
            // 
            bntAdd.Location = new Point(42, 318);
            bntAdd.Name = "bntAdd";
            bntAdd.Size = new Size(94, 29);
            bntAdd.TabIndex = 2;
            bntAdd.Text = "Add";
            bntAdd.UseVisualStyleBackColor = true;
            bntAdd.Click += btnAdd_Click;
            // 
            // btnEdit
            // 
            btnEdit.Location = new Point(379, 318);
            btnEdit.Name = "btnEdit";
            btnEdit.Size = new Size(94, 29);
            btnEdit.TabIndex = 3;
            btnEdit.Text = "Edit";
            btnEdit.UseVisualStyleBackColor = true;
            btnEdit.Click += btnEdit_Click;
            // 
            // btnDelete
            // 
            btnDelete.Location = new Point(712, 318);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(94, 29);
            btnDelete.TabIndex = 4;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(833, 450);
            Controls.Add(btnDelete);
            Controls.Add(btnEdit);
            Controls.Add(bntAdd);
            Controls.Add(listView1);
            Controls.Add(treeView1);
            Name = "Form1";
            Text = "Główny plik";
            ResumeLayout(false);
        }

        #endregion

        private TreeView treeView1;
        private ListView listView1;
        private Button bntAdd;
        private Button btnEdit;
        private Button btnDelete;
    }
}
