﻿using System;

namespace TeduShop.Model.Abstract
{
    public interface IAuditable
    {
        DateTime? CreateDate { get; set; }
        string CreateBy { get; set; }
        DateTime? UpdateDate { get; set; }
        string UpdateBy { get; set; }
        string MetaKeyword { get; set; }
        string MetaDecription { get; set; }
        bool Status { get; set; }
    }
}
