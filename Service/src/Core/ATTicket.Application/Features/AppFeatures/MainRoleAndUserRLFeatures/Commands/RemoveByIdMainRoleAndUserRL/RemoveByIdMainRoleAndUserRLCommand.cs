﻿using ATTicket.Application.Messaging;
namespace ATTicket.Application.Features.AppFeatures.MainRoleAndUserRLFeatures.Commands.RemoveByIdMainRoleAndUserRL;
public sealed record RemoveByIdMainRoleAndUserRLCommand(string Id) : ICommand<RemoveByIdMainRoleAndUserRLCommandResponse>;