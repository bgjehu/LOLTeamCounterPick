using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//extra
using System.Windows.Forms;

namespace LOLTeamCounterPick.Classes
{
    class SelectChampionPB : PictureBox
    {
        #region Extra Private Variables
        //private bool _isActive;
        private bool _isSelected;
        private Champion _champion;
        private ChampionPB _SelectedChampionPB;
        private int _mode;
        #endregion
        #region Extra Public Variables
        public bool isSelected { get { return _isSelected; } set { _isSelected = value; } }
        public Champion champion { get { return _champion; } set { _champion = value; } }
        public ChampionPB SelectedChampionPB { get { return _SelectedChampionPB; } set { _SelectedChampionPB = value; } }
        public int mode { get { return _mode; } }
        //public bool isSActive { get { return _isActive; } set { _isActive = value; } }

        #endregion




        private void boxClicked(object sender, EventArgs e)
        {
            

            if (GVs.selectedSlot == null)
            {
                if (_isSelected) { SelectedChampionPB.active(); }
                BorderStyle = BorderStyle.Fixed3D;
                GVs.selectedSlot = this;
            }
            else if (GVs.selectedSlot == this)
            {

                //did not select champino and click again
                GVs.selectedSlot = null;
                GVs.selectedChampion = null;
                BorderStyle = BorderStyle.FixedSingle;
            }
            else
            {
                if (_isSelected) { SelectedChampionPB.active(); }
                GVs.selectedChampion = null;
                if (((SelectChampionPB)GVs.selectedSlot).isSelected)
                {
                    ((SelectChampionPB)GVs.selectedSlot).BorderStyle = BorderStyle.FixedSingle;
                    BorderStyle = BorderStyle.Fixed3D;
                    GVs.selectedSlot = this;
                }
                else
                {
                    ((SelectChampionPB)GVs.selectedSlot).BorderStyle = BorderStyle.FixedSingle;
                    BorderStyle = BorderStyle.Fixed3D;
                    GVs.selectedSlot = this;
                }

            }
            
        }

        public SelectChampionPB(int mode)
        {
            Click += new System.EventHandler(boxClicked);
            Dock = DockStyle.None;
            Margin = new Padding(1);
            SizeMode = PictureBoxSizeMode.Normal;
            Width = 60;
            Height = 60;
            BackgroundImageLayout = ImageLayout.Stretch;
            _isSelected = false;
            _mode = mode;
            
        }
        public void Report()
        {
            if (_champion != null) 
            {
                if (_champion.name != null) 
                {
                    switch (mode)
                    {
                        case 0:
                            GVs.banList.Add(_champion.name);
                            break;
                        case 1:
                            GVs.allyList.Add(_champion.name);
                            break;
                        case 2:
                            GVs.oppoList.Add(_champion.name);
                            break;
                    }
                }
            }
        }
        public void Reset()
        {
            BackgroundImage = null;
            _isSelected = false;
            _champion = null;
            _SelectedChampionPB = null;
            BorderStyle = BorderStyle.FixedSingle;
        }
    }
}
