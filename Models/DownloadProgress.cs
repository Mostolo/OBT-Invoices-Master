using System;
using System.Collections.Generic;
using System.Text;

namespace OBT_Invoices_Master.Models
{
    internal class DownloadProgress
    {
        public long BytesDownloaded { get; set; }

        public long? TotalBytes { get; set; }

        public double BytesPerSecond { get; set; }

        public TimeSpan Elapsed { get; set; }

        public TimeSpan? Remaining { get; set; }

        public double Percentage
        {
            get
            {
                if (TotalBytes is null || TotalBytes == 0)
                {
                    return 0;
                }

                return (double)BytesDownloaded / TotalBytes.Value * 100;
            }
        }
    }
}

