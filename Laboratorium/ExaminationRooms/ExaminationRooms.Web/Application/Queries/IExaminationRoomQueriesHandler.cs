﻿namespace ExaminationRooms.Web.Application
{
    using ExaminationRooms.Domain.ExaminationRoomAggregate;
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;

    public interface IExaminationRoomQueriesHandler
    {
        IEnumerable<ExaminationRoomDto> GetAll();
        IEnumerable<ExaminationRoomDto> GetByCertificationType(int certificationType);
    }
}
