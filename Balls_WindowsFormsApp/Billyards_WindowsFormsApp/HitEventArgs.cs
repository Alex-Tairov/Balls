using System;

namespace Billyards_WindowsFormsApp
{
    public class HitEventArgs : EventArgs
    {
        public Side Side;
        
        public HitEventArgs(Side side)
        {
            Side = side;
        }
    }
}
