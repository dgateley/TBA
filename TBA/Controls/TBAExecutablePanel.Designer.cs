namespace TBA.Controls
{
    partial class TBAExecutablePanel
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblMachinePrefix = new System.Windows.Forms.Label();
            this.lblMachine = new System.Windows.Forms.Label();
            this.lblSections = new System.Windows.Forms.Label();
            this.lblSectionsPrefix = new System.Windows.Forms.Label();
            this.lblTime = new System.Windows.Forms.Label();
            this.lblTimePrefix = new System.Windows.Forms.Label();
            this.lblCodeSize = new System.Windows.Forms.Label();
            this.lblSymbolsPrefix = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblMachinePrefix
            // 
            this.lblMachinePrefix.AutoSize = true;
            this.lblMachinePrefix.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMachinePrefix.Location = new System.Drawing.Point(13, 14);
            this.lblMachinePrefix.Name = "lblMachinePrefix";
            this.lblMachinePrefix.Size = new System.Drawing.Size(128, 25);
            this.lblMachinePrefix.TabIndex = 0;
            this.lblMachinePrefix.Text = "Architecture: ";
            // 
            // lblMachine
            // 
            this.lblMachine.AutoSize = true;
            this.lblMachine.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMachine.Location = new System.Drawing.Point(136, 14);
            this.lblMachine.Name = "lblMachine";
            this.lblMachine.Size = new System.Drawing.Size(41, 25);
            this.lblMachine.TabIndex = 1;
            this.lblMachine.Text = "x86";
            // 
            // lblSections
            // 
            this.lblSections.AutoSize = true;
            this.lblSections.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSections.Location = new System.Drawing.Point(136, 44);
            this.lblSections.Name = "lblSections";
            this.lblSections.Size = new System.Drawing.Size(32, 25);
            this.lblSections.TabIndex = 3;
            this.lblSections.Text = "52";
            // 
            // lblSectionsPrefix
            // 
            this.lblSectionsPrefix.AutoSize = true;
            this.lblSectionsPrefix.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSectionsPrefix.Location = new System.Drawing.Point(13, 44);
            this.lblSectionsPrefix.Name = "lblSectionsPrefix";
            this.lblSectionsPrefix.Size = new System.Drawing.Size(125, 25);
            this.lblSectionsPrefix.TabIndex = 2;
            this.lblSectionsPrefix.Text = "# of sections:";
            // 
            // lblTime
            // 
            this.lblTime.AutoSize = true;
            this.lblTime.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTime.Location = new System.Drawing.Point(67, 74);
            this.lblTime.Name = "lblTime";
            this.lblTime.Size = new System.Drawing.Size(32, 25);
            this.lblTime.TabIndex = 5;
            this.lblTime.Text = "52";
            // 
            // lblTimePrefix
            // 
            this.lblTimePrefix.AutoSize = true;
            this.lblTimePrefix.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTimePrefix.Location = new System.Drawing.Point(13, 74);
            this.lblTimePrefix.Name = "lblTimePrefix";
            this.lblTimePrefix.Size = new System.Drawing.Size(58, 25);
            this.lblTimePrefix.TabIndex = 4;
            this.lblTimePrefix.Text = "Date:";
            // 
            // lblCodeSize
            // 
            this.lblCodeSize.AutoSize = true;
            this.lblCodeSize.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCodeSize.Location = new System.Drawing.Point(136, 104);
            this.lblCodeSize.Name = "lblCodeSize";
            this.lblCodeSize.Size = new System.Drawing.Size(32, 25);
            this.lblCodeSize.TabIndex = 7;
            this.lblCodeSize.Text = "52";
            // 
            // lblSymbolsPrefix
            // 
            this.lblSymbolsPrefix.AutoSize = true;
            this.lblSymbolsPrefix.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSymbolsPrefix.Location = new System.Drawing.Point(13, 104);
            this.lblSymbolsPrefix.Name = "lblSymbolsPrefix";
            this.lblSymbolsPrefix.Size = new System.Drawing.Size(120, 25);
            this.lblSymbolsPrefix.TabIndex = 6;
            this.lblSymbolsPrefix.Text = "Size of code:";
            // 
            // TBAExecutablePanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.lblCodeSize);
            this.Controls.Add(this.lblSymbolsPrefix);
            this.Controls.Add(this.lblTime);
            this.Controls.Add(this.lblTimePrefix);
            this.Controls.Add(this.lblSections);
            this.Controls.Add(this.lblSectionsPrefix);
            this.Controls.Add(this.lblMachine);
            this.Controls.Add(this.lblMachinePrefix);
            this.Name = "TBAExecutablePanel";
            this.Size = new System.Drawing.Size(550, 289);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblMachinePrefix;
        private System.Windows.Forms.Label lblMachine;
        private System.Windows.Forms.Label lblSections;
        private System.Windows.Forms.Label lblSectionsPrefix;
        private System.Windows.Forms.Label lblTime;
        private System.Windows.Forms.Label lblTimePrefix;
        private System.Windows.Forms.Label lblCodeSize;
        private System.Windows.Forms.Label lblSymbolsPrefix;
    }
}
