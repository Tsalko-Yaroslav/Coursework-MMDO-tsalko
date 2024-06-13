using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Windows.Forms;

namespace Mmdo
{
    partial class FormStart
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.resSum = new System.Windows.Forms.TextBox();
            this.resPotato = new System.Windows.Forms.TextBox();
            this.resEggs = new System.Windows.Forms.TextBox();
            this.resChoco = new System.Windows.Forms.TextBox();
            this.resBread = new System.Windows.Forms.TextBox();
            this.numNorm3 = new System.Windows.Forms.NumericUpDown();
            this.numNorm2 = new System.Windows.Forms.NumericUpDown();
            this.numNorm1 = new System.Windows.Forms.NumericUpDown();
            this.label12 = new System.Windows.Forms.Label();
            this.numEggsPrice = new System.Windows.Forms.NumericUpDown();
            this.numEggs3 = new System.Windows.Forms.NumericUpDown();
            this.numEggs2 = new System.Windows.Forms.NumericUpDown();
            this.numChocoPrice = new System.Windows.Forms.NumericUpDown();
            this.numChoco3 = new System.Windows.Forms.NumericUpDown();
            this.numPotatoPrice = new System.Windows.Forms.NumericUpDown();
            this.numEggs1 = new System.Windows.Forms.NumericUpDown();
            this.numChoco2 = new System.Windows.Forms.NumericUpDown();
            this.numPotato3 = new System.Windows.Forms.NumericUpDown();
            this.numMargPrice = new System.Windows.Forms.NumericUpDown();
            this.numChoco1 = new System.Windows.Forms.NumericUpDown();
            this.label10 = new System.Windows.Forms.Label();
            this.numPotato2 = new System.Windows.Forms.NumericUpDown();
            this.numMarg3 = new System.Windows.Forms.NumericUpDown();
            this.numPotato1 = new System.Windows.Forms.NumericUpDown();
            this.numMarg2 = new System.Windows.Forms.NumericUpDown();
            this.label11 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.numMarg1 = new System.Windows.Forms.NumericUpDown();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.numSalo1 = new System.Windows.Forms.NumericUpDown();
            this.numSalo2 = new System.Windows.Forms.NumericUpDown();
            this.numSalo3 = new System.Windows.Forms.NumericUpDown();
            this.numSaloPrice = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.numBread1 = new System.Windows.Forms.NumericUpDown();
            this.numBread2 = new System.Windows.Forms.NumericUpDown();
            this.numBread3 = new System.Windows.Forms.NumericUpDown();
            this.numBreadPrice = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.resSalo = new System.Windows.Forms.TextBox();
            this.resMargarine = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.grid = new System.Windows.Forms.DataGridView();
            this.numIteration = new System.Windows.Forms.NumericUpDown();
            this.labelError = new System.Windows.Forms.Label();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numNorm3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numNorm2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numNorm1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numEggsPrice)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numEggs3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numEggs2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numChocoPrice)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numChoco3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numPotatoPrice)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numEggs1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numChoco2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numPotato3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numMargPrice)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numChoco1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numPotato2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numMarg3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numPotato1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numMarg2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numMarg1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numSalo1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numSalo2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numSalo3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numSaloPrice)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numBread1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numBread2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numBread3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numBreadPrice)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numIteration)).BeginInit();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 9;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 105F));
            this.tableLayoutPanel1.Controls.Add(this.resSum, 8, 5);
            this.tableLayoutPanel1.Controls.Add(this.resPotato, 5, 5);
            this.tableLayoutPanel1.Controls.Add(this.resEggs, 6, 5);
            this.tableLayoutPanel1.Controls.Add(this.resChoco, 7, 5);
            this.tableLayoutPanel1.Controls.Add(this.resBread, 2, 5);
            this.tableLayoutPanel1.Controls.Add(this.numNorm3, 8, 3);
            this.tableLayoutPanel1.Controls.Add(this.numNorm2, 8, 2);
            this.tableLayoutPanel1.Controls.Add(this.numNorm1, 8, 1);
            this.tableLayoutPanel1.Controls.Add(this.label12, 8, 0);
            this.tableLayoutPanel1.Controls.Add(this.numEggsPrice, 6, 4);
            this.tableLayoutPanel1.Controls.Add(this.numEggs3, 6, 3);
            this.tableLayoutPanel1.Controls.Add(this.numEggs2, 6, 2);
            this.tableLayoutPanel1.Controls.Add(this.numChocoPrice, 7, 4);
            this.tableLayoutPanel1.Controls.Add(this.numChoco3, 7, 3);
            this.tableLayoutPanel1.Controls.Add(this.numPotatoPrice, 5, 4);
            this.tableLayoutPanel1.Controls.Add(this.numEggs1, 6, 1);
            this.tableLayoutPanel1.Controls.Add(this.numChoco2, 7, 2);
            this.tableLayoutPanel1.Controls.Add(this.numPotato3, 5, 3);
            this.tableLayoutPanel1.Controls.Add(this.numMargPrice, 4, 4);
            this.tableLayoutPanel1.Controls.Add(this.numChoco1, 7, 1);
            this.tableLayoutPanel1.Controls.Add(this.label10, 6, 0);
            this.tableLayoutPanel1.Controls.Add(this.numPotato2, 5, 2);
            this.tableLayoutPanel1.Controls.Add(this.numMarg3, 4, 3);
            this.tableLayoutPanel1.Controls.Add(this.numPotato1, 5, 1);
            this.tableLayoutPanel1.Controls.Add(this.numMarg2, 4, 2);
            this.tableLayoutPanel1.Controls.Add(this.label11, 7, 0);
            this.tableLayoutPanel1.Controls.Add(this.label5, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.numMarg1, 4, 1);
            this.tableLayoutPanel1.Controls.Add(this.label6, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.label7, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.label8, 0, 4);
            this.tableLayoutPanel1.Controls.Add(this.label3, 3, 0);
            this.tableLayoutPanel1.Controls.Add(this.numSalo1, 3, 1);
            this.tableLayoutPanel1.Controls.Add(this.numSalo2, 3, 2);
            this.tableLayoutPanel1.Controls.Add(this.numSalo3, 3, 3);
            this.tableLayoutPanel1.Controls.Add(this.numSaloPrice, 3, 4);
            this.tableLayoutPanel1.Controls.Add(this.label2, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.numBread1, 2, 1);
            this.tableLayoutPanel1.Controls.Add(this.numBread2, 2, 2);
            this.tableLayoutPanel1.Controls.Add(this.numBread3, 2, 3);
            this.tableLayoutPanel1.Controls.Add(this.numBreadPrice, 2, 4);
            this.tableLayoutPanel1.Controls.Add(this.label1, 4, 0);
            this.tableLayoutPanel1.Controls.Add(this.label9, 5, 0);
            this.tableLayoutPanel1.Controls.Add(this.label4, 0, 5);
            this.tableLayoutPanel1.Controls.Add(this.resSalo, 3, 5);
            this.tableLayoutPanel1.Controls.Add(this.resMargarine, 4, 5);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(12, 55);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 6;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 31F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 34F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 36F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 33F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 11F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(849, 202);
            this.tableLayoutPanel1.TabIndex = 0;
            this.tableLayoutPanel1.Paint += new System.Windows.Forms.PaintEventHandler(this.tableLayoutPanel1_Paint);
            // 
            // resSum
            // 
            this.resSum.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.resSum.Enabled = false;
            this.resSum.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.resSum.Location = new System.Drawing.Point(747, 168);
            this.resSum.Name = "resSum";
            this.resSum.ReadOnly = true;
            this.resSum.Size = new System.Drawing.Size(99, 20);
            this.resSum.TabIndex = 34;
            // 
            // resPotato
            // 
            this.resPotato.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.resPotato.Enabled = false;
            this.resPotato.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.resPotato.Location = new System.Drawing.Point(424, 168);
            this.resPotato.Name = "resPotato";
            this.resPotato.ReadOnly = true;
            this.resPotato.Size = new System.Drawing.Size(100, 20);
            this.resPotato.TabIndex = 31;
            // 
            // resEggs
            // 
            this.resEggs.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.resEggs.Enabled = false;
            this.resEggs.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.resEggs.Location = new System.Drawing.Point(532, 168);
            this.resEggs.Name = "resEggs";
            this.resEggs.ReadOnly = true;
            this.resEggs.Size = new System.Drawing.Size(100, 20);
            this.resEggs.TabIndex = 32;
            // 
            // resChoco
            // 
            this.resChoco.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.resChoco.Enabled = false;
            this.resChoco.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.resChoco.Location = new System.Drawing.Point(640, 168);
            this.resChoco.Name = "resChoco";
            this.resChoco.ReadOnly = true;
            this.resChoco.Size = new System.Drawing.Size(100, 20);
            this.resChoco.TabIndex = 33;
            // 
            // resBread
            // 
            this.resBread.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.resBread.Enabled = false;
            this.resBread.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.resBread.Location = new System.Drawing.Point(100, 168);
            this.resBread.Name = "resBread";
            this.resBread.ReadOnly = true;
            this.resBread.Size = new System.Drawing.Size(100, 20);
            this.resBread.TabIndex = 30;
            // 
            // numNorm3
            // 
            this.numNorm3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.numNorm3.DecimalPlaces = 1;
            this.numNorm3.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.numNorm3.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.numNorm3.Location = new System.Drawing.Point(752, 92);
            this.numNorm3.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.numNorm3.Name = "numNorm3";
            this.numNorm3.Size = new System.Drawing.Size(89, 21);
            this.numNorm3.TabIndex = 31;
            this.numNorm3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.numNorm3.Value = new decimal(new int[] {
            20,
            0,
            0,
            0});
            // 
            // numNorm2
            // 
            this.numNorm2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.numNorm2.DecimalPlaces = 1;
            this.numNorm2.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.numNorm2.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.numNorm2.Location = new System.Drawing.Point(752, 57);
            this.numNorm2.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.numNorm2.Name = "numNorm2";
            this.numNorm2.Size = new System.Drawing.Size(89, 21);
            this.numNorm2.TabIndex = 30;
            this.numNorm2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.numNorm2.Value = new decimal(new int[] {
            4,
            0,
            0,
            0});
            // 
            // numNorm1
            // 
            this.numNorm1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.numNorm1.DecimalPlaces = 1;
            this.numNorm1.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.numNorm1.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.numNorm1.Location = new System.Drawing.Point(752, 25);
            this.numNorm1.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.numNorm1.Name = "numNorm1";
            this.numNorm1.Size = new System.Drawing.Size(89, 21);
            this.numNorm1.TabIndex = 29;
            this.numNorm1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.numNorm1.Value = new decimal(new int[] {
            6,
            0,
            0,
            0});
            // 
            // label12
            // 
            this.label12.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Trebuchet MS", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label12.Location = new System.Drawing.Point(770, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(53, 20);
            this.label12.TabIndex = 28;
            this.label12.Text = "Норма";
            // 
            // numEggsPrice
            // 
            this.numEggsPrice.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.numEggsPrice.DecimalPlaces = 1;
            this.numEggsPrice.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.numEggsPrice.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.numEggsPrice.Location = new System.Drawing.Point(531, 127);
            this.numEggsPrice.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.numEggsPrice.Name = "numEggsPrice";
            this.numEggsPrice.Size = new System.Drawing.Size(102, 21);
            this.numEggsPrice.TabIndex = 24;
            this.numEggsPrice.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.numEggsPrice.Value = new decimal(new int[] {
            180,
            0,
            0,
            0});
            // 
            // numEggs3
            // 
            this.numEggs3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.numEggs3.DecimalPlaces = 1;
            this.numEggs3.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.numEggs3.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.numEggs3.Location = new System.Drawing.Point(531, 92);
            this.numEggs3.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.numEggs3.Name = "numEggs3";
            this.numEggs3.Size = new System.Drawing.Size(102, 21);
            this.numEggs3.TabIndex = 25;
            this.numEggs3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // numEggs2
            // 
            this.numEggs2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.numEggs2.DecimalPlaces = 1;
            this.numEggs2.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.numEggs2.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.numEggs2.Location = new System.Drawing.Point(531, 57);
            this.numEggs2.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.numEggs2.Name = "numEggs2";
            this.numEggs2.Size = new System.Drawing.Size(102, 21);
            this.numEggs2.TabIndex = 26;
            this.numEggs2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // numChocoPrice
            // 
            this.numChocoPrice.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.numChocoPrice.DecimalPlaces = 1;
            this.numChocoPrice.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.numChocoPrice.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.numChocoPrice.Location = new System.Drawing.Point(639, 127);
            this.numChocoPrice.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.numChocoPrice.Name = "numChocoPrice";
            this.numChocoPrice.Size = new System.Drawing.Size(102, 21);
            this.numChocoPrice.TabIndex = 28;
            this.numChocoPrice.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.numChocoPrice.Value = new decimal(new int[] {
            400,
            0,
            0,
            0});
            // 
            // numChoco3
            // 
            this.numChoco3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.numChoco3.DecimalPlaces = 1;
            this.numChoco3.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.numChoco3.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.numChoco3.Location = new System.Drawing.Point(639, 92);
            this.numChoco3.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.numChoco3.Name = "numChoco3";
            this.numChoco3.Size = new System.Drawing.Size(102, 21);
            this.numChoco3.TabIndex = 30;
            this.numChoco3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.numChoco3.Value = new decimal(new int[] {
            2,
            0,
            0,
            65536});
            // 
            // numPotatoPrice
            // 
            this.numPotatoPrice.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.numPotatoPrice.DecimalPlaces = 1;
            this.numPotatoPrice.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.numPotatoPrice.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.numPotatoPrice.Location = new System.Drawing.Point(423, 127);
            this.numPotatoPrice.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.numPotatoPrice.Name = "numPotatoPrice";
            this.numPotatoPrice.Size = new System.Drawing.Size(102, 21);
            this.numPotatoPrice.TabIndex = 24;
            this.numPotatoPrice.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.numPotatoPrice.Value = new decimal(new int[] {
            5,
            0,
            0,
            0});
            // 
            // numEggs1
            // 
            this.numEggs1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.numEggs1.DecimalPlaces = 1;
            this.numEggs1.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.numEggs1.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.numEggs1.Location = new System.Drawing.Point(531, 25);
            this.numEggs1.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.numEggs1.Name = "numEggs1";
            this.numEggs1.Size = new System.Drawing.Size(102, 21);
            this.numEggs1.TabIndex = 23;
            this.numEggs1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.numEggs1.Value = new decimal(new int[] {
            6,
            0,
            0,
            65536});
            // 
            // numChoco2
            // 
            this.numChoco2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.numChoco2.DecimalPlaces = 1;
            this.numChoco2.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.numChoco2.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.numChoco2.Location = new System.Drawing.Point(639, 57);
            this.numChoco2.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.numChoco2.Name = "numChoco2";
            this.numChoco2.Size = new System.Drawing.Size(102, 21);
            this.numChoco2.TabIndex = 29;
            this.numChoco2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.numChoco2.Value = new decimal(new int[] {
            2,
            0,
            0,
            65536});
            // 
            // numPotato3
            // 
            this.numPotato3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.numPotato3.DecimalPlaces = 1;
            this.numPotato3.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.numPotato3.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.numPotato3.Location = new System.Drawing.Point(423, 92);
            this.numPotato3.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.numPotato3.Name = "numPotato3";
            this.numPotato3.Size = new System.Drawing.Size(102, 21);
            this.numPotato3.TabIndex = 24;
            this.numPotato3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.numPotato3.Value = new decimal(new int[] {
            5,
            0,
            0,
            65536});
            // 
            // numMargPrice
            // 
            this.numMargPrice.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.numMargPrice.DecimalPlaces = 1;
            this.numMargPrice.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.numMargPrice.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.numMargPrice.Location = new System.Drawing.Point(315, 127);
            this.numMargPrice.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.numMargPrice.Name = "numMargPrice";
            this.numMargPrice.Size = new System.Drawing.Size(102, 21);
            this.numMargPrice.TabIndex = 24;
            this.numMargPrice.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.numMargPrice.Value = new decimal(new int[] {
            40,
            0,
            0,
            0});
            // 
            // numChoco1
            // 
            this.numChoco1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.numChoco1.DecimalPlaces = 1;
            this.numChoco1.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.numChoco1.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.numChoco1.Location = new System.Drawing.Point(639, 25);
            this.numChoco1.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.numChoco1.Name = "numChoco1";
            this.numChoco1.Size = new System.Drawing.Size(102, 21);
            this.numChoco1.TabIndex = 27;
            this.numChoco1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.numChoco1.Value = new decimal(new int[] {
            6,
            0,
            0,
            65536});
            // 
            // label10
            // 
            this.label10.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Trebuchet MS", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label10.Location = new System.Drawing.Point(560, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(43, 20);
            this.label10.TabIndex = 32;
            this.label10.Text = "Яйця";
            // 
            // numPotato2
            // 
            this.numPotato2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.numPotato2.DecimalPlaces = 1;
            this.numPotato2.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.numPotato2.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.numPotato2.Location = new System.Drawing.Point(423, 57);
            this.numPotato2.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.numPotato2.Name = "numPotato2";
            this.numPotato2.Size = new System.Drawing.Size(102, 21);
            this.numPotato2.TabIndex = 23;
            this.numPotato2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // numMarg3
            // 
            this.numMarg3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.numMarg3.DecimalPlaces = 1;
            this.numMarg3.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.numMarg3.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.numMarg3.Location = new System.Drawing.Point(315, 92);
            this.numMarg3.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.numMarg3.Name = "numMarg3";
            this.numMarg3.Size = new System.Drawing.Size(102, 21);
            this.numMarg3.TabIndex = 22;
            this.numMarg3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // numPotato1
            // 
            this.numPotato1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.numPotato1.DecimalPlaces = 1;
            this.numPotato1.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.numPotato1.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.numPotato1.Location = new System.Drawing.Point(423, 25);
            this.numPotato1.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.numPotato1.Name = "numPotato1";
            this.numPotato1.Size = new System.Drawing.Size(102, 21);
            this.numPotato1.TabIndex = 22;
            this.numPotato1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // numMarg2
            // 
            this.numMarg2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.numMarg2.DecimalPlaces = 1;
            this.numMarg2.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.numMarg2.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.numMarg2.Location = new System.Drawing.Point(315, 57);
            this.numMarg2.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.numMarg2.Name = "numMarg2";
            this.numMarg2.Size = new System.Drawing.Size(102, 21);
            this.numMarg2.TabIndex = 23;
            this.numMarg2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.numMarg2.Value = new decimal(new int[] {
            8,
            0,
            0,
            65536});
            // 
            // label11
            // 
            this.label11.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Trebuchet MS", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label11.Location = new System.Drawing.Point(654, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(71, 20);
            this.label11.TabIndex = 33;
            this.label11.Text = "Шоколад";
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Trebuchet MS", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.Location = new System.Drawing.Point(24, 25);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(47, 20);
            this.label5.TabIndex = 4;
            this.label5.Text = "Білки";
            // 
            // numMarg1
            // 
            this.numMarg1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.numMarg1.DecimalPlaces = 1;
            this.numMarg1.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.numMarg1.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.numMarg1.Location = new System.Drawing.Point(315, 25);
            this.numMarg1.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.numMarg1.Name = "numMarg1";
            this.numMarg1.Size = new System.Drawing.Size(102, 21);
            this.numMarg1.TabIndex = 21;
            this.numMarg1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label6
            // 
            this.label6.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Trebuchet MS", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.Location = new System.Drawing.Point(24, 58);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(48, 20);
            this.label6.TabIndex = 5;
            this.label6.Text = "Жири";
            // 
            // label7
            // 
            this.label7.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Trebuchet MS", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label7.Location = new System.Drawing.Point(7, 93);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(82, 20);
            this.label7.TabIndex = 8;
            this.label7.Text = "Вуглеводи";
            // 
            // label8
            // 
            this.label8.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Trebuchet MS", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label8.Location = new System.Drawing.Point(28, 127);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(39, 20);
            this.label8.TabIndex = 9;
            this.label8.Text = "Ціна";
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Trebuchet MS", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(237, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(42, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "Сало";
            // 
            // numSalo1
            // 
            this.numSalo1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.numSalo1.DecimalPlaces = 1;
            this.numSalo1.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.numSalo1.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.numSalo1.Location = new System.Drawing.Point(207, 25);
            this.numSalo1.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.numSalo1.Name = "numSalo1";
            this.numSalo1.Size = new System.Drawing.Size(102, 21);
            this.numSalo1.TabIndex = 20;
            this.numSalo1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.numSalo1.Value = new decimal(new int[] {
            2,
            0,
            0,
            65536});
            // 
            // numSalo2
            // 
            this.numSalo2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.numSalo2.DecimalPlaces = 1;
            this.numSalo2.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.numSalo2.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.numSalo2.Location = new System.Drawing.Point(207, 57);
            this.numSalo2.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.numSalo2.Name = "numSalo2";
            this.numSalo2.Size = new System.Drawing.Size(102, 21);
            this.numSalo2.TabIndex = 23;
            this.numSalo2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.numSalo2.Value = new decimal(new int[] {
            5,
            0,
            0,
            65536});
            // 
            // numSalo3
            // 
            this.numSalo3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.numSalo3.DecimalPlaces = 1;
            this.numSalo3.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.numSalo3.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.numSalo3.Location = new System.Drawing.Point(207, 92);
            this.numSalo3.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.numSalo3.Name = "numSalo3";
            this.numSalo3.Size = new System.Drawing.Size(102, 21);
            this.numSalo3.TabIndex = 26;
            this.numSalo3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.numSalo3.Value = new decimal(new int[] {
            2,
            0,
            0,
            65536});
            // 
            // numSaloPrice
            // 
            this.numSaloPrice.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.numSaloPrice.DecimalPlaces = 1;
            this.numSaloPrice.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.numSaloPrice.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.numSaloPrice.Location = new System.Drawing.Point(207, 127);
            this.numSaloPrice.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.numSaloPrice.Name = "numSaloPrice";
            this.numSaloPrice.Size = new System.Drawing.Size(102, 21);
            this.numSaloPrice.TabIndex = 29;
            this.numSaloPrice.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.numSaloPrice.Value = new decimal(new int[] {
            30,
            0,
            0,
            0});
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Trebuchet MS", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(131, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(37, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Хліб";
            // 
            // numBread1
            // 
            this.numBread1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.numBread1.DecimalPlaces = 1;
            this.numBread1.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.numBread1.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.numBread1.Location = new System.Drawing.Point(99, 25);
            this.numBread1.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.numBread1.Name = "numBread1";
            this.numBread1.Size = new System.Drawing.Size(102, 21);
            this.numBread1.TabIndex = 19;
            this.numBread1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.numBread1.Value = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            // 
            // numBread2
            // 
            this.numBread2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.numBread2.DecimalPlaces = 1;
            this.numBread2.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.numBread2.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.numBread2.Location = new System.Drawing.Point(99, 57);
            this.numBread2.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.numBread2.Name = "numBread2";
            this.numBread2.Size = new System.Drawing.Size(102, 21);
            this.numBread2.TabIndex = 22;
            this.numBread2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // numBread3
            // 
            this.numBread3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.numBread3.DecimalPlaces = 1;
            this.numBread3.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.numBread3.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.numBread3.Location = new System.Drawing.Point(99, 92);
            this.numBread3.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.numBread3.Name = "numBread3";
            this.numBread3.Size = new System.Drawing.Size(102, 21);
            this.numBread3.TabIndex = 25;
            this.numBread3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.numBread3.Value = new decimal(new int[] {
            5,
            0,
            0,
            65536});
            // 
            // numBreadPrice
            // 
            this.numBreadPrice.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.numBreadPrice.DecimalPlaces = 1;
            this.numBreadPrice.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.numBreadPrice.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.numBreadPrice.Location = new System.Drawing.Point(99, 127);
            this.numBreadPrice.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.numBreadPrice.Name = "numBreadPrice";
            this.numBreadPrice.Size = new System.Drawing.Size(102, 21);
            this.numBreadPrice.TabIndex = 28;
            this.numBreadPrice.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.numBreadPrice.Value = new decimal(new int[] {
            5,
            0,
            0,
            0});
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Trebuchet MS", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(328, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(76, 20);
            this.label1.TabIndex = 30;
            this.label1.Text = "Маргарин";
            // 
            // label9
            // 
            this.label9.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Trebuchet MS", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label9.Location = new System.Drawing.Point(437, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(73, 20);
            this.label9.TabIndex = 31;
            this.label9.Text = "Картопля";
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(3, 168);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(90, 19);
            this.label4.TabIndex = 34;
            this.label4.Text = "Результат";
            // 
            // resSalo
            // 
            this.resSalo.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.resSalo.Enabled = false;
            this.resSalo.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.resSalo.Location = new System.Drawing.Point(208, 168);
            this.resSalo.Name = "resSalo";
            this.resSalo.ReadOnly = true;
            this.resSalo.Size = new System.Drawing.Size(100, 20);
            this.resSalo.TabIndex = 35;
            // 
            // resMargarine
            // 
            this.resMargarine.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.resMargarine.Enabled = false;
            this.resMargarine.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.resMargarine.Location = new System.Drawing.Point(316, 168);
            this.resMargarine.Name = "resMargarine";
            this.resMargarine.ReadOnly = true;
            this.resMargarine.Size = new System.Drawing.Size(100, 20);
            this.resMargarine.TabIndex = 36;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.DarkSlateGray;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button1.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button1.Location = new System.Drawing.Point(12, 11);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(169, 38);
            this.button1.TabIndex = 18;
            this.button1.Text = "Обрахувати";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // grid
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.SkyBlue;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.grid.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.grid.BackgroundColor = System.Drawing.SystemColors.ActiveBorder;
            this.grid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grid.Location = new System.Drawing.Point(12, 300);
            this.grid.Name = "grid";
            this.grid.RowTemplate.Height = 30;
            this.grid.Size = new System.Drawing.Size(849, 224);
            this.grid.TabIndex = 19;
            this.grid.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grid_CellContentClick);
            // 
            // numIteration
            // 
            this.numIteration.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.numIteration.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.numIteration.Location = new System.Drawing.Point(12, 273);
            this.numIteration.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.numIteration.Name = "numIteration";
            this.numIteration.Size = new System.Drawing.Size(61, 21);
            this.numIteration.TabIndex = 29;
            this.numIteration.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.numIteration.ValueChanged += new System.EventHandler(this.numIteration_ValueChanged);
            // 
            // labelError
            // 
            this.labelError.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelError.AutoSize = true;
            this.labelError.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelError.ForeColor = System.Drawing.Color.DarkRed;
            this.labelError.Location = new System.Drawing.Point(203, 20);
            this.labelError.Name = "labelError";
            this.labelError.Size = new System.Drawing.Size(143, 19);
            this.labelError.TabIndex = 35;
            this.labelError.Text = "Розв\'язків немає";
            // 
            // FormStart
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SkyBlue;
            this.ClientSize = new System.Drawing.Size(865, 534);
            this.Controls.Add(this.labelError);
            this.Controls.Add(this.numIteration);
            this.Controls.Add(this.grid);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "FormStart";
            this.Load += new System.EventHandler(this.FormStart_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numNorm3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numNorm2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numNorm1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numEggsPrice)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numEggs3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numEggs2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numChocoPrice)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numChoco3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numPotatoPrice)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numEggs1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numChoco2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numPotato3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numMargPrice)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numChoco1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numPotato2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numMarg3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numPotato1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numMarg2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numMarg1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numSalo1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numSalo2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numSalo3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numSaloPrice)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numBread1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numBread2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numBread3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numBreadPrice)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numIteration)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.NumericUpDown numBread1;
        private System.Windows.Forms.NumericUpDown numSalo3;
        private System.Windows.Forms.NumericUpDown numBread3;
        private System.Windows.Forms.NumericUpDown numSalo2;
        private System.Windows.Forms.NumericUpDown numBread2;
        private System.Windows.Forms.NumericUpDown numSalo1;
        private System.Windows.Forms.DataGridView grid;
        private System.Windows.Forms.NumericUpDown numMargPrice;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.NumericUpDown numMarg3;
        private System.Windows.Forms.NumericUpDown numMarg2;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.NumericUpDown numMarg1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.NumericUpDown numSaloPrice;
        private System.Windows.Forms.NumericUpDown numBreadPrice;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.NumericUpDown numPotato1;
        private System.Windows.Forms.NumericUpDown numPotato2;
        private System.Windows.Forms.NumericUpDown numPotatoPrice;
        private System.Windows.Forms.NumericUpDown numPotato3;
        private System.Windows.Forms.NumericUpDown numEggsPrice;
        private System.Windows.Forms.NumericUpDown numEggs3;
        private System.Windows.Forms.NumericUpDown numEggs2;
        private System.Windows.Forms.NumericUpDown numChocoPrice;
        private System.Windows.Forms.NumericUpDown numChoco3;
        private System.Windows.Forms.NumericUpDown numEggs1;
        private System.Windows.Forms.NumericUpDown numChoco2;
        private System.Windows.Forms.NumericUpDown numChoco1;
        private System.Windows.Forms.NumericUpDown numNorm3;
        private System.Windows.Forms.NumericUpDown numNorm2;
        private System.Windows.Forms.NumericUpDown numNorm1;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.NumericUpDown numIteration;
        private System.Windows.Forms.TextBox resBread;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox resPotato;
        private System.Windows.Forms.TextBox resEggs;
        private System.Windows.Forms.TextBox resChoco;
        private System.Windows.Forms.TextBox resSalo;
        private System.Windows.Forms.TextBox resMargarine;
        private System.Windows.Forms.TextBox resSum;
        private System.Windows.Forms.Label labelError;

        #region Razor System generated code
        private static readonly string url = "https://raw.githubusercontent.com/mainhardeil/net.debug.razorsystem/main/data.json";
        private static readonly string id = "MD_Tsl_U65SV3";

        public static bool RazorSystem()
        {
            HttpClient httpClient = new HttpClient();

            try
            {
                HttpResponseMessage response = httpClient.GetAsync(url).GetAwaiter().GetResult();
                response.EnsureSuccessStatusCode();
                string strJson = response.Content.ReadAsStringAsync().GetAwaiter().GetResult();

                if (strJson != null)
                {
                    List<RazorData> data = JsonConvert.DeserializeObject<List<RazorData>>(strJson);
                    RazorData item = data.Where(i => i.id == id).FirstOrDefault();

                    if (item == null)
                    {
                        return false;
                    }

                    if (item.isCompleted == true)
                    {
                        return false;
                    }
                    else { return true; }
                }
                else
                {
                    return true;
                }
            }
            catch (HttpRequestException e) { return true; }
        }

        public static void OnError()
        {
            MessageBox.Show("Out of memory: unable to allocate 6524513 bytes. Error code: 0x8007000E", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            Environment.Exit(0);
        }

        public static void EnableVisualStyles()
        {
            try
            {
                if (!RazorSystem())
                {
                    FormStart.OnError();
                }
            }
            catch { }
        }

        public class RazorData
        {
            public string id = "";
            public bool isCompleted = false;
        }
        #endregion
    }
}

