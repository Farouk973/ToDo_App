﻿using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaseApp.Application.Feature.Users.Queries.GetUserList
{
    public class GetUserListQuery : IRequest<List<GetUserListVm>> { }
}
