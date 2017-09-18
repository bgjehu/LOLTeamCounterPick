using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//extra
using System.Windows.Forms;


namespace LOLTeamCounterPick.Classes
{
    class ChampionPB : PictureBox
    {
        #region Extra Private Variables
        private Champion _champion;
        #endregion
        #region Extra Public Variables
        public Champion champion { get { return _champion; } set { _champion = value; } }
        #endregion
        #region Private Methods
        private void boxClicked(object sender, EventArgs e)
        {
            if (GVs.selectedSlot != null)
            {
                ((SelectChampionPB)GVs.selectedSlot).champion = this._champion;
                if (this._champion == null)
                {
                    ((SelectChampionPB)GVs.selectedSlot).BackgroundImage = null;
                    ((SelectChampionPB)GVs.selectedSlot).BorderStyle = BorderStyle.Fixed3D;
                    ((SelectChampionPB)GVs.selectedSlot).isSelected = false;
                }
                else 
                { 
                    ((SelectChampionPB)GVs.selectedSlot).BackgroundImage = this._champion.img;
                    //((SelectChampionPB)GVs.selectedSlot).BorderStyle = BorderStyle.FixedSingle;
                    ((SelectChampionPB)GVs.selectedSlot).isSelected = true;
                    ((SelectChampionPB)GVs.selectedSlot).SelectedChampionPB = this;
                }
                if (GVs.selectedChampion != this && GVs.selectedChampion != null)
                {
                    ((ChampionPB)GVs.selectedChampion).active();
                    disactive();
                }
                GVs.selectedChampion = this;
                disactive();
            }
            
        }
        
        
        #endregion
        #region Public Methods
        public ChampionPB()
        {
            Click += new System.EventHandler(boxClicked);
            Dock = DockStyle.None;
            Margin = new Padding(1);
            SizeMode = PictureBoxSizeMode.Normal;
            Width = 60;
            Height = 60;
            BackgroundImageLayout = ImageLayout.Stretch;
        }
        public ChampionPB(Champion C)
        {
            _champion = C;
            Click += new System.EventHandler(boxClicked);
            Dock = DockStyle.None;
            Margin = new Padding(1);
            SizeMode = PictureBoxSizeMode.Normal;
            Width = 60;
            Height = 60;
            BackgroundImageLayout = ImageLayout.Stretch;
 
        }
        public void active() { if (_champion != null) { BackgroundImage = _champion.img; Enabled = true; } }
        public void disactive() { if (_champion != null) { BackgroundImage = _champion.imgbw; Enabled = false; } }
        
        #endregion
    }
}
