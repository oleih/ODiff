﻿namespace ODiff.Filters
{
    public class NoFilter : IDiffFilter
    {
        public bool Include(DiffReportTableRow row)
        {
            return true;
        }
    }
}
