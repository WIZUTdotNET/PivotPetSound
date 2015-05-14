using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PivotPetSounds.ViewModels
{
    public class SoundModel
    {
        public SoundGroup Animals { get; set; }
        public SoundGroup Cartoons { get; set; }
        public SoundGroup CustomSounds { get; set; }

        public bool IsDataLoaded { get; set; }

        public void LoadData()
        {
            IsDataLoaded = true;
        }
    }
}
