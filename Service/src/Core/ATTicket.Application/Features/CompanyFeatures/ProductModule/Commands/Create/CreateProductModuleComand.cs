﻿namespace ATTicket.Application.Features.CompanyFeatures.ProductModule.Commands.Create;
public sealed record CreateProductModuleComand(string ProductId, string ProductModuleName) : ICommand<CreateProductModuleComandResponse>;
