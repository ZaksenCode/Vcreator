using System.Diagnostics;
using System.Security.Policy;
using System.Windows.Forms.VisualStyles;

namespace Vcreator
{
    public partial class BlockEditor : Form
    {
        private string jsonText = "";
        private Dictionary<String, String> textValues = new Dictionary<String, String>()
        {
            { "picking-item", "" },
            { "texture", "" },
            { "model", "" },
            { "rotation", "" }
        };
        private int draw_group = 0;
        private string[] textureFaces = new string[6];
        private double[] hitbox = new double[6];
        private Dictionary<String, Boolean> booleanValues = new Dictionary<String, Boolean>()
        {
            { "hidden", false },
            { "light-passing", false },
            { "sky-light-passing", false },
            { "obstacle", true },
            { "selectable", true },
            { "replaceable", false },
            { "breakable", true }
        };

        public BlockEditor()
        {
            InitializeComponent();
            updateBlockJson();
        }

        private void Save_Click(object sender, EventArgs e)
        {
            saveFileDialog.ShowDialog();
        }

        private void saveFileDialog_FileOk(object sender, System.ComponentModel.CancelEventArgs e)
        {
            string path = saveFileDialog.FileName;
            File.WriteAllText(path, "{\n" + jsonText + "\n}");
        }

        private void blockJson_TextChanged(object sender, EventArgs e)
        {
            updateBlockJson();
        }

        private void updateTextValue(string key, string value)
        {
            textValues.Remove(key);
            textValues.Add(key, value);
        }

        private void updateBlockJson()
        {
            jsonText = "";
            jsonText += "\t\"draw-group\":" + draw_group + ",\n";
            foreach (KeyValuePair<string, string> kvp in textValues)
            {
                if (!String.IsNullOrEmpty(kvp.Value))
                {
                    jsonText += "\t\"" + kvp.Key + "\":\"" + kvp.Value + "\",\n";
                }
            }
            if (!TextureCheckBox.Checked)
            {
                string texture_faces_json = "\t\"texture-faces\": [\n";
                for (int i = 0; i < textureFaces.Length; i++)
                {
                    if (i < textureFaces.Length - 1)
                    {
                        texture_faces_json += "\t\t\"" + textureFaces[i] + "\",\n";
                    }
                    else
                    {
                        texture_faces_json += "\t\t\"" + textureFaces[i] + "\"\n\t],\n";
                    }
                }
                jsonText += texture_faces_json;
            }
            if (hitboxCheck.Checked)
            {
                string hitbox_json = "\t\"hitbox\": [\n";
                for (int i = 0; i < hitbox.Length; i++)
                {
                    if (i < hitbox.Length - 1)
                    {
                        hitbox_json += "\t\t" + hitbox[i].ToString().Replace(',', '.') + ",\n";
                    }
                    else
                    {
                        hitbox_json += "\t\t" + hitbox[i].ToString().Replace(',', '.') + "\n\t],\n";
                    }
                }
                jsonText += hitbox_json;
            }
            foreach (KeyValuePair<string, bool> kvp in booleanValues)
            {
                if (kvp.Key != "breakable")
                {
                    jsonText += "\t\"" + kvp.Key + "\":" + boolToString(kvp.Value) + ",\n";
                }
                else
                {
                    jsonText += "\t\"" + kvp.Key + "\":" + boolToString(kvp.Value);
                }
            }
        }

        private void toggleText(string text)
        {
            Boolean booleanValue;

            if (booleanValues.ContainsKey(text))
            {
                booleanValues.TryGetValue(text, out booleanValue);
                booleanValues.Remove(text);
                booleanValues.Add(text, !booleanValue);
            }
            updateBlockJson();
        }

        private string boolToString(bool boolValue)
        {
            return boolValue ? "true" : "false";
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            toggleText("hidden");
            pickingBox.Enabled = !pickingBox.Enabled;
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            toggleText("light-passing");
        }

        private void replacibleBox_CheckedChanged(object sender, EventArgs e)
        {
            toggleText("replaceable");
        }

        private void breakableBox_CheckedChanged(object sender, EventArgs e)
        {
            toggleText("breakable");
        }

        private void selectableBox_CheckedChanged(object sender, EventArgs e)
        {
            toggleText("selectable");
        }

        private void obstacleBox_CheckedChanged(object sender, EventArgs e)
        {
            toggleText("obstacle");
        }

        private void pickingBox_TextChanged(object sender, EventArgs e)
        {
            updateTextValue("picking-item", pickingBox.Text);
            updateBlockJson();
        }


        private void TextureCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (TextureCheckBox.Checked)
            {
                textureBox.Enabled = true;
                textureXm.Enabled = false;
                textureXp.Enabled = false;
                textureYm.Enabled = false;
                textureYp.Enabled = false;
                textureZm.Enabled = false;
                textureZp.Enabled = false;
            }
            else
            {
                textureBox.Enabled = false;
                textureXm.Enabled = true;
                textureXp.Enabled = true;
                textureYm.Enabled = true;
                textureYp.Enabled = true;
                textureZm.Enabled = true;
                textureZp.Enabled = true;
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            updateTextValue("model", comboBox1.Text);
            updateBlockJson();
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            updateTextValue("rotation", comboBox2.Text);
            updateBlockJson();
        }

        private void textureBox_TextChanged(object sender, EventArgs e)
        {
            updateTextValue("texture", textureBox.Text);
            updateBlockJson();
        }

        private void hitboxCheck_CheckedChanged(object sender, EventArgs e)
        {
            if (hitboxCheck.Checked)
            {
                offsetX.Enabled = true;
                offsetY.Enabled = true;
                offsetZ.Enabled = true;
                sizeX.Enabled = true;
                sizeY.Enabled = true;
                sizeZ.Enabled = true;
            }
            else
            {
                offsetX.Enabled = false;
                offsetY.Enabled = false;
                offsetZ.Enabled = false;
                sizeX.Enabled = false;
                sizeY.Enabled = false;
                sizeZ.Enabled = false;
            }
        }

        private void textureXm_TextChanged(object sender, EventArgs e)
        {
            textureFaces[0] = textureXm.Text;
            updateBlockJson();
        }

        private void textureXp_TextChanged(object sender, EventArgs e)
        {
            textureFaces[1] = textureXp.Text;
            updateBlockJson();
        }

        private void textureYm_TextChanged(object sender, EventArgs e)
        {
            textureFaces[2] = textureYm.Text;
            updateBlockJson();
        }

        private void textureYp_TextChanged(object sender, EventArgs e)
        {
            textureFaces[3] = textureYp.Text;
            updateBlockJson();
        }

        private void textureZm_TextChanged(object sender, EventArgs e)
        {
            textureFaces[4] = textureZm.Text;
            updateBlockJson();
        }

        private void textureZp_TextChanged(object sender, EventArgs e)
        {
            textureFaces[5] = textureZp.Text;
            updateBlockJson();
        }

        private void offsetX_ValueChanged(object sender, EventArgs e)
        {
            hitbox[0] = (double)offsetX.Value;
            updateBlockJson();
        }

        private void offsetY_ValueChanged(object sender, EventArgs e)
        {
            hitbox[1] = (double)offsetY.Value;
            updateBlockJson();
        }

        private void offsetZ_ValueChanged(object sender, EventArgs e)
        {
            hitbox[2] = (double)offsetZ.Value;
            updateBlockJson();
        }

        private void sizeX_ValueChanged(object sender, EventArgs e)
        {
            hitbox[3] = (double)sizeX.Value;
            updateBlockJson();
        }

        private void sizeY_ValueChanged(object sender, EventArgs e)
        {
            hitbox[4] = (double)sizeY.Value;
            updateBlockJson();
        }

        private void sizeZ_ValueChanged(object sender, EventArgs e)
        {
            hitbox[5] = (double)sizeZ.Value;
            updateBlockJson();
        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            draw_group = (int) numericUpDown1.Value;
            updateBlockJson();
        }
    }
}
