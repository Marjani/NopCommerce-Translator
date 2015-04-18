// Copyright (c) 2015 AmirHossein Marjani
// License: Code Project Open License
// Author: amirhossein@marjani.net
// http://marjani.net/blog
// http://www.codeproject.com/info/cpol10.aspx

using Marjani.Net.Utility;
using System;
using System.IO;
using System.Linq;
using System.Threading;
using System.Windows.Forms;
using System.Xml;


namespace Marjani.Net.GoogleTranslator
{
    /// <summary>
    /// A sample application to demonstrate the <see cref="Translator"/> class.
    /// </summary>
    public partial class GoogleTranslatorFrm : Form
    {
        #region Constructor

        /// <summary>
        /// Initializes a new instance of the <see cref="GoogleTranslatorFrm"/> class.
        /// </summary>
        public GoogleTranslatorFrm()
        {
            InitializeComponent();
        }

        #endregion

        #region Form event handlers

        /// <summary>
        /// Handles the Load event of the GoogleTranslatorFrm control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="System.EventArgs"/> instance containing the event data.</param>
        private void GoogleTranslatorFrm_Load
            (object sender,
             EventArgs e)
        {
            //this._comboFrom.Items.AddRange(Translator.Languages.ToArray());
            this._comboTo.Items.AddRange(Translator.Languages.ToArray());
            //this._comboFrom.SelectedItem = "English";
            this._comboTo.SelectedItem = "Persian";
        }

        #endregion

        #region Button handlers

        /// <summary>
        /// Handles the Click event of the _btnTranslate control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="System.EventArgs"/> instance containing the event data.</param>
        private void _btnTranslate_Click
            (object sender,
            EventArgs e)
        {
            if (dgvData.Rows.Count < 1)
            {
                MessageBox.Show("There aren't any record! please import language xml file");
                return;
            }
            for (int i = 0; i < dgvData.Rows.Count; i++)
            {
                var row = dgvData.Rows[i];
                // Initialize the translator
                Marjani.Net.Utility.Translator t = new Marjani.Net.Utility.Translator();

                t.TargetLanguage = (string)this._comboTo.SelectedItem;

                t.SourceText = row.Cells[1].Value.ToString();

                // Translate the text
                try
                {

                    this.Cursor = Cursors.WaitCursor;
                    this._lblStatus.Text = "Translating... Line (" + (i + 1) + "): " + row.Cells[1].Value.ToString();
                    this._lblStatus.Update();
                    t.Translate();

                    row.Cells[2].Value = t.Translation;
                    dgvData.Refresh();

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, this.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
                finally
                {
                    this._lblStatus.Text = string.Empty;
                    this.Cursor = Cursors.Default;
                }
            }
        }

        #endregion

        private void btnChooseFile_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofdChoseXMLFile = new OpenFileDialog();
            ofdChoseXMLFile.Multiselect = false;
            ofdChoseXMLFile.Filter = "XML Files (.xml)|*.xml";

            var dialogResult = ofdChoseXMLFile.ShowDialog();

            if (dialogResult != System.Windows.Forms.DialogResult.OK)
            {
                return;
            }
            var filePath = ofdChoseXMLFile.FileName;
            if (!IsValidLanguageFile(filePath))
            {
                MessageBox.Show("This file isn't true file, please select another XML file!");
                return;
            }

            XmlDocument xmlDoc = new XmlDocument();
            xmlDoc.Load(filePath);
            XmlNodeList nodeList = xmlDoc.DocumentElement.SelectNodes("LocaleResource");

            lblSourceInfo.Text = nodeList.Count + " rows founded!";


            foreach (XmlNode node in nodeList)
            {
                dgvData.Rows.Add(new string[] { node.Attributes["Name"].Value, node.FirstChild.InnerText });
            }
        }

        private bool IsValidLanguageFile(string filePath)
        {
            try
            {
                XmlDocument xmlDoc = new XmlDocument();
                xmlDoc.Load(filePath);
                XmlNodeList nodeList = xmlDoc.DocumentElement.SelectNodes("LocaleResource");
                if (nodeList.Count > 0)
                {
                    return true;
                }
                return false;
            }
            catch (Exception ex)
            {
                return false;
            }
        }

        private void btnExport_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog fbd = new FolderBrowserDialog();
            DialogResult result = fbd.ShowDialog();
            if (result != System.Windows.Forms.DialogResult.OK)
            {
                MessageBox.Show("Please select folder to export!");
                return;
            }

            var targetXML = new XmlDocument();
            XmlNode docNode = targetXML.CreateXmlDeclaration("1.0", "UTF-8", null);
            targetXML.AppendChild(docNode);

            var parentNode = targetXML.CreateElement("Language");
            parentNode.SetAttribute("Name", _comboTo.Text);

            foreach (DataGridViewRow row in dgvData.Rows)
            {
                XmlElement localeResourceNode = targetXML.CreateElement("LocaleResource");
                localeResourceNode.SetAttribute("Name", row.Cells[0].Value.ToString());

                XmlElement valueNode = targetXML.CreateElement("Value");
                valueNode.InnerText = row.Cells[2].Value.ToString();

                localeResourceNode.AppendChild(valueNode);

                parentNode.AppendChild(localeResourceNode);
            }
            targetXML.AppendChild(parentNode);
            targetXML.Save(fbd.SelectedPath + @"\language_pack.xml");
            MessageBox.Show("Completed!");
        }

    }
}
