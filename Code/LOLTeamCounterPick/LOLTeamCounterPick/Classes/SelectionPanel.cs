using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//extra
using System.Windows.Forms;

namespace LOLTeamCounterPick.Classes
{
    class SelectionPanel
    {
        #region Private Variables
        private TableLayoutPanel _panel;
        private List<ChampionPB> _pictureBoxes;
        #endregion
        #region Public Variables
        public TableLayoutPanel panel { get { return _panel; } }
        public List<ChampionPB> pictureBoxes { get { return pictureBoxes; } }
        #endregion
        #region Private Methods
        private void initialTableLayoutPanel()
        {
            // 
            // selectionPanel
            // 
            _panel.AutoScroll = true;
            _panel.ColumnCount = 10;
            _panel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            _panel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            _panel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            _panel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            _panel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            _panel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            _panel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            _panel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            _panel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            _panel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            _panel.GrowStyle = System.Windows.Forms.TableLayoutPanelGrowStyle.FixedSize;
            _panel.Location = new System.Drawing.Point(7, 14);
            _panel.Name = "selectionPanel";
            _panel.RowCount = 13;
            _panel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 60F));
            _panel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 60F));
            _panel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 60F));
            _panel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 60F));
            _panel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 60F));
            _panel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 60F));
            _panel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 60F));
            _panel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 60F));
            _panel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 60F));
            _panel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 60F));
            _panel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 60F));
            _panel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 60F));
            _panel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 60F));
            _panel.Size = new System.Drawing.Size(623, 332);
            _panel.TabIndex = 0;
        }
        private void LoadPictureBoxes(ChampionList championlist, bool isForSelection)
        {
            _pictureBoxes.Clear();
            if (isForSelection)
            {
                ChampionPB tmp = new ChampionPB();
                tmp.BorderStyle = BorderStyle.FixedSingle;
                _pictureBoxes.Add(tmp);
            }
            foreach (Champion champion in championlist.list)
            {
                ChampionPB tmpPB = new ChampionPB(champion);
                tmpPB.active();
                _pictureBoxes.Add(tmpPB);
            }

        }
        #endregion
        #region Public Methods
        public SelectionPanel()
        {
            _panel=new TableLayoutPanel();
            _pictureBoxes = new List<ChampionPB>();
            initialTableLayoutPanel();
        }
        public void LoadSelectionPanel(ChampionList championlist, bool isForSelection)
        {
            _panel.Controls.Clear();
            int count = -1;
            LoadPictureBoxes(championlist, isForSelection);
            for (int row = 0; row < _panel.RowCount; row++)
            {
                for (int column = 0; column < _panel.ColumnCount; column++)
                {
                    if (isForSelection)
                    {
                        if (count < championlist.list.Count)
                        {
                            _panel.Controls.Add(_pictureBoxes[++count], column, row);
                        }
                    }
                    else 
                    {
                        if (count < championlist.list.Count - 1)
                        {
                            _panel.Controls.Add(_pictureBoxes[++count], column, row);
                        }
                    }
                }
            }
        }
        public void active()
        {
            foreach (ChampionPB CPB in _pictureBoxes) { CPB.active(); }
        }
        public void disactive()
        {
            foreach (ChampionPB CPB in _pictureBoxes) { CPB.disactive(); }
        }
        public void enable()
        {
            foreach (ChampionPB CPB in _pictureBoxes) { CPB.Enabled = true; }
            _panel.VerticalScroll.Value = 0;
        }
        public void disable()
        {
            foreach (ChampionPB CPB in _pictureBoxes) { CPB.Enabled = false; }
            _panel.VerticalScroll.Value = 0;
            
        }
        #endregion
    }
}
