﻿namespace ATTicket.Domain.Dtos; 
public sealed class ContractDto : Entity
{
    public string AppUserId { get; set; }
    public string? ContractNo { get; set; }
    public int? ContractType { get; set; }
    public string? Definition { get; set; }
    public DateTime BegDate { get; set; }
    public DateTime EndDate { get; set; }
    public bool Active { get; set; }
    public string? Explanation { get; set; }
    public double? Amount { get; set; }
    public string? Currency { get; set; }
    public string? OrderNr { get; set; }
    public string? CreatedUser { get; set; }
}

