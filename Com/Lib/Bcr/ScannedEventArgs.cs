namespace Com.Lib.Bcr
{
    using Com.Lib.Bcr.Utils;
    using System;

    public class ScannedEventArgs : EventArgs
    {
        private BARCODE.TYPE p0;
        private string p1;
        private int p2;

        public ScannedEventArgs(BARCODE.TYPE p0, string p1, int p2)
        {
            this.p0 = p0;
            this.p1 = p1;
            this.p2 = p2;
        }

        public BARCODE.TYPE P0
        {
            get
            {
                return this.p0;
            }
        }

        public string P1
        {
            get
            {
                return this.p1;
            }
        }

        public int P2
        {
            get
            {
                return this.p2;
            }
        }
    }
}

