
namespace Defolt_RPG_1._0
{
    partial class MainMenu
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainMenu));
            this.buttonStartNewGame = new System.Windows.Forms.Button();
            this.buttonLoadGame = new System.Windows.Forms.Button();
            this.buttonSettings = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // buttonStartNewGame
            // 
            this.buttonStartNewGame.Location = new System.Drawing.Point(485, 148);
            this.buttonStartNewGame.Name = "buttonStartNewGame";
            this.buttonStartNewGame.Size = new System.Drawing.Size(264, 69);
            this.buttonStartNewGame.TabIndex = 0;
            this.buttonStartNewGame.Text = "Новая игра";
            this.buttonStartNewGame.UseVisualStyleBackColor = true;
            this.buttonStartNewGame.Click += new System.EventHandler(this.buttonStartNewGame_Click);
            // 
            // buttonLoadGame
            // 
            this.buttonLoadGame.Location = new System.Drawing.Point(485, 223);
            this.buttonLoadGame.Name = "buttonLoadGame";
            this.buttonLoadGame.Size = new System.Drawing.Size(264, 71);
            this.buttonLoadGame.TabIndex = 1;
            this.buttonLoadGame.Text = "Загрузить игру";
            this.buttonLoadGame.UseVisualStyleBackColor = true;
            // 
            // buttonSettings
            // 
            this.buttonSettings.Location = new System.Drawing.Point(485, 301);
            this.buttonSettings.Name = "buttonSettings";
            this.buttonSettings.Size = new System.Drawing.Size(264, 72);
            this.buttonSettings.TabIndex = 2;
            this.buttonSettings.Text = "Настройки";
            this.buttonSettings.UseVisualStyleBackColor = true;
            // 
            // MainMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1244, 681);
            this.Controls.Add(this.buttonSettings);
            this.Controls.Add(this.buttonLoadGame);
            this.Controls.Add(this.buttonStartNewGame);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MainMenu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Ничем не выдающаяся РПГ игра про героя-одиночку";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonStartNewGame;
        private System.Windows.Forms.Button buttonLoadGame;
        private System.Windows.Forms.Button buttonSettings;
    }
}

