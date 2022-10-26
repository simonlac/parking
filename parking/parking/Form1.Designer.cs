namespace parking
{
    partial class Form1
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.infopar = new System.Windows.Forms.TabPage();
            this.infovoi = new System.Windows.Forms.TabPage();
            this.Noml = new System.Windows.Forms.Label();
            this.textbnom = new System.Windows.Forms.TextBox();
            this.taillel = new System.Windows.Forms.Label();
            this.textbtaille = new System.Windows.Forms.TextBox();
            this.crparking = new System.Windows.Forms.Button();
            this.afparking = new System.Windows.Forms.Button();
            this.plaque = new System.Windows.Forms.Label();
            this.Marque = new System.Windows.Forms.Label();
            this.nuplaque = new System.Windows.Forms.TextBox();
            this.marq = new System.Windows.Forms.TextBox();
            this.modèle = new System.Windows.Forms.Label();
            this.model = new System.Windows.Forms.TextBox();
            this.Couleur = new System.Windows.Forms.Label();
            this.textcoul = new System.Windows.Forms.TextBox();
            this.butentrer = new System.Windows.Forms.Button();
            this.butsorti = new System.Windows.Forms.Button();
            this.tabControl1.SuspendLayout();
            this.infopar.SuspendLayout();
            this.infovoi.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.infopar);
            this.tabControl1.Controls.Add(this.infovoi);
            this.tabControl1.Location = new System.Drawing.Point(87, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(555, 406);
            this.tabControl1.TabIndex = 0;
            // 
            // infopar
            // 
            this.infopar.BackColor = System.Drawing.Color.Gainsboro;
            this.infopar.Controls.Add(this.afparking);
            this.infopar.Controls.Add(this.crparking);
            this.infopar.Controls.Add(this.textbtaille);
            this.infopar.Controls.Add(this.taillel);
            this.infopar.Controls.Add(this.textbnom);
            this.infopar.Controls.Add(this.Noml);
            this.infopar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.infopar.Location = new System.Drawing.Point(4, 22);
            this.infopar.Name = "infopar";
            this.infopar.Padding = new System.Windows.Forms.Padding(3);
            this.infopar.Size = new System.Drawing.Size(547, 380);
            this.infopar.TabIndex = 0;
            this.infopar.Text = "Info parking";
            // 
            // infovoi
            // 
            this.infovoi.BackColor = System.Drawing.Color.Gainsboro;
            this.infovoi.Controls.Add(this.butsorti);
            this.infovoi.Controls.Add(this.butentrer);
            this.infovoi.Controls.Add(this.textcoul);
            this.infovoi.Controls.Add(this.Couleur);
            this.infovoi.Controls.Add(this.model);
            this.infovoi.Controls.Add(this.modèle);
            this.infovoi.Controls.Add(this.marq);
            this.infovoi.Controls.Add(this.nuplaque);
            this.infovoi.Controls.Add(this.Marque);
            this.infovoi.Controls.Add(this.plaque);
            this.infovoi.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.infovoi.Location = new System.Drawing.Point(4, 22);
            this.infovoi.Name = "infovoi";
            this.infovoi.Padding = new System.Windows.Forms.Padding(3);
            this.infovoi.Size = new System.Drawing.Size(547, 380);
            this.infovoi.TabIndex = 1;
            this.infovoi.Text = "Info voiture";
            // 
            // Noml
            // 
            this.Noml.AutoSize = true;
            this.Noml.Location = new System.Drawing.Point(26, 19);
            this.Noml.Name = "Noml";
            this.Noml.Size = new System.Drawing.Size(42, 20);
            this.Noml.TabIndex = 0;
            this.Noml.Text = "Nom";
           
            // 
            // textbnom
            // 
            this.textbnom.Location = new System.Drawing.Point(30, 42);
            this.textbnom.Name = "textbnom";
            this.textbnom.Size = new System.Drawing.Size(353, 26);
            this.textbnom.TabIndex = 1;
            
            // 
            // taillel
            // 
            this.taillel.AutoSize = true;
            this.taillel.Location = new System.Drawing.Point(26, 87);
            this.taillel.Name = "taillel";
            this.taillel.Size = new System.Drawing.Size(41, 20);
            this.taillel.TabIndex = 2;
            this.taillel.Text = "taille";
           
            // 
            // textbtaille
            // 
            this.textbtaille.Location = new System.Drawing.Point(30, 110);
            this.textbtaille.Name = "textbtaille";
            this.textbtaille.Size = new System.Drawing.Size(353, 26);
            this.textbtaille.TabIndex = 3;
            // 
            // crparking
            // 
            this.crparking.Location = new System.Drawing.Point(30, 206);
            this.crparking.Name = "crparking";
            this.crparking.Size = new System.Drawing.Size(203, 39);
            this.crparking.TabIndex = 4;
            this.crparking.Text = "crée parking";
            this.crparking.UseVisualStyleBackColor = true;
            // 
            // afparking
            // 
            this.afparking.Location = new System.Drawing.Point(30, 264);
            this.afparking.Name = "afparking";
            this.afparking.Size = new System.Drawing.Size(203, 39);
            this.afparking.TabIndex = 5;
            this.afparking.Text = "afficher parking";
            this.afparking.UseVisualStyleBackColor = true;
            // 
            // plaque
            // 
            this.plaque.AutoSize = true;
            this.plaque.Location = new System.Drawing.Point(25, 7);
            this.plaque.Name = "plaque";
            this.plaque.Size = new System.Drawing.Size(145, 20);
            this.plaque.TabIndex = 0;
            this.plaque.Text = "Numéro de plaque";
            // 
            // Marque
            // 
            this.Marque.AutoSize = true;
            this.Marque.Location = new System.Drawing.Point(25, 77);
            this.Marque.Name = "Marque";
            this.Marque.Size = new System.Drawing.Size(65, 20);
            this.Marque.TabIndex = 1;
            this.Marque.Text = "Marque";
           
            // 
            // nuplaque
            // 
            this.nuplaque.Location = new System.Drawing.Point(29, 31);
            this.nuplaque.Name = "nuplaque";
            this.nuplaque.Size = new System.Drawing.Size(255, 26);
            this.nuplaque.TabIndex = 2;
            // 
            // marq
            // 
            this.marq.Location = new System.Drawing.Point(29, 100);
            this.marq.Name = "marq";
            this.marq.Size = new System.Drawing.Size(255, 26);
            this.marq.TabIndex = 3;
            // 
            // modèle
            // 
            this.modèle.AutoSize = true;
            this.modèle.Location = new System.Drawing.Point(25, 148);
            this.modèle.Name = "modèle";
            this.modèle.Size = new System.Drawing.Size(63, 20);
            this.modèle.TabIndex = 4;
            this.modèle.Text = "Modèle";
            // 
            // model
            // 
            this.model.Location = new System.Drawing.Point(29, 172);
            this.model.Name = "model";
            this.model.Size = new System.Drawing.Size(255, 26);
            this.model.TabIndex = 5;
            // 
            // Couleur
            // 
            this.Couleur.AutoSize = true;
            this.Couleur.Location = new System.Drawing.Point(29, 222);
            this.Couleur.Name = "Couleur";
            this.Couleur.Size = new System.Drawing.Size(67, 20);
            this.Couleur.TabIndex = 6;
            this.Couleur.Text = "Couleur";
            // 
            // textcoul
            // 
            this.textcoul.Location = new System.Drawing.Point(29, 260);
            this.textcoul.Name = "textcoul";
            this.textcoul.Size = new System.Drawing.Size(255, 26);
            this.textcoul.TabIndex = 7;
            // 
            // butentrer
            // 
            this.butentrer.Location = new System.Drawing.Point(33, 326);
            this.butentrer.Name = "butentrer";
            this.butentrer.Size = new System.Drawing.Size(173, 34);
            this.butentrer.TabIndex = 8;
            this.butentrer.Text = "entrer voiture";
            this.butentrer.UseVisualStyleBackColor = true;
            // 
            // butsorti
            // 
            this.butsorti.Location = new System.Drawing.Point(269, 326);
            this.butsorti.Name = "butsorti";
            this.butsorti.Size = new System.Drawing.Size(173, 34);
            this.butsorti.TabIndex = 9;
            this.butsorti.Text = "sortir voiture";
            this.butsorti.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tabControl1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.tabControl1.ResumeLayout(false);
            this.infopar.ResumeLayout(false);
            this.infopar.PerformLayout();
            this.infovoi.ResumeLayout(false);
            this.infovoi.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage infopar;
        private System.Windows.Forms.TabPage infovoi;
        private System.Windows.Forms.Label Noml;
        private System.Windows.Forms.TextBox textbnom;
        private System.Windows.Forms.Label taillel;
        private System.Windows.Forms.Button afparking;
        private System.Windows.Forms.Button crparking;
        private System.Windows.Forms.TextBox textbtaille;
        private System.Windows.Forms.TextBox nuplaque;
        private System.Windows.Forms.Label Marque;
        private System.Windows.Forms.Label plaque;
        private System.Windows.Forms.Button butsorti;
        private System.Windows.Forms.Button butentrer;
        private System.Windows.Forms.TextBox textcoul;
        private System.Windows.Forms.Label Couleur;
        private System.Windows.Forms.TextBox model;
        private System.Windows.Forms.Label modèle;
        private System.Windows.Forms.TextBox marq;
    }
}

