using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace modul4_1302210006
{
    internal class PosisiKarakterGame_1302210006
    {
        public enum stateChara { 
            Berdiri,
            Jongkok,
            Tengkurap,
            Terbang
        }

        public enum btnTrigger { 
            TombolW,
            TombolS,
            TombolX
        }

        private stateChara currentState = stateChara.Berdiri;

        public class stateTransition_1302210006 {
            public stateChara stateAwal;
            public stateChara stateAkhir;
            public btnTrigger trigger;

            public stateTransition_1302210006(stateChara statusAwal, stateChara statusAkhir, btnTrigger trigger) { 
                this.stateAwal = statusAwal;
                this.stateAkhir = statusAkhir;
                this.trigger = trigger;
            }
        }

        stateTransition_1302210006[] transition = new stateTransition_1302210006[]{
            new stateTransition_1302210006(stateChara.Berdiri, stateChara.Terbang, btnTrigger.TombolW),
            new stateTransition_1302210006(stateChara.Berdiri, stateChara.Jongkok, btnTrigger.TombolS),
            new stateTransition_1302210006(stateChara.Terbang, stateChara.Berdiri, btnTrigger.TombolS),
            new stateTransition_1302210006(stateChara.Terbang, stateChara.Jongkok, btnTrigger.TombolX),
            new stateTransition_1302210006(stateChara.Jongkok, stateChara.Tengkurap, btnTrigger.TombolS),
            new stateTransition_1302210006(stateChara.Tengkurap, stateChara.Jongkok, btnTrigger.TombolW),
            new stateTransition_1302210006(stateChara.Jongkok, stateChara.Berdiri, btnTrigger.TombolW),
        };

        private stateChara GetNextStateChara_1302210006(stateChara stateAwal, btnTrigger trigger) {
            stateChara statusAkhir = stateAwal;
            for (int i = 0; i < transition.Length; i++) { 
                stateTransition_1302210006 update = transition[i];
                if (stateAwal == update.stateAwal && trigger == update.trigger) { 
                    statusAkhir = update.stateAkhir;
                }
            }
            return statusAkhir;
        }

        public void activateTrigger_1302210006(btnTrigger trigger) {
            currentState = GetNextStateChara_1302210006(currentState, trigger);
            Console.WriteLine(currentState);

            if (currentState == stateChara.Berdiri) {
                Console.WriteLine("Berdiri");
            } else
            {
                Console.WriteLine("Terbang");
            }
        }

        public void implementasiModNim(stateChara statusAkhir ,btnTrigger trigger) {
            int nim = 1302210006;
            if (nim % 3 == 0)
            {
                if (trigger == btnTrigger.TombolS)
                {
                    Console.WriteLine("Tombol arah bawah ditekan");
                }
                else if (trigger == btnTrigger.TombolW)
                {
                    Console.WriteLine("Tombol arah atas ditekan");
                }
                else
                {
                    Console.WriteLine("Tombol tidak ditekan");
                }
            }
        }
    }
}
