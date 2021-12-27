﻿using MyWebApp.Entities.Concrete;
using MyWebApp.Shared.Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Text;

namespace MyWebApp.Entities.Dtos.InterestedDtos
{
    public class InterestedListDto : DtoGetBase
    {
        public IList<Interested> Interesteds { get; set; }
    }
}
