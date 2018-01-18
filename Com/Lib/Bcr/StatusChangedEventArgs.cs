namespace Com.Lib.Bcr
{
    using System;

    public class StatusChangedEventArgs : EventArgs
    {
        private int p0;

        public StatusChangedEventArgs(int p0)
        {
            this.p0 = p0;
        }

        public int P0
        {
            get
            {
                return this.p0;
            }
        }
    }
}

