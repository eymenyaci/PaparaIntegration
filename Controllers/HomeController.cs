﻿using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using Microsoft.VisualBasic;
using PaparaIntegration.Interfaces;
using PaparaIntegration.Models;

using PaparaIntegration.Models.Endpoints;
using PaparaIntegration.Models.Request.Account;
using PaparaIntegration.Models.Request.Payment;

namespace PaparaIntegration.Controllers;

public class HomeController : Controller
{
    private readonly IMassPaymentService _massPaymentService;
    private readonly IAccountService _accountService;

    private readonly IPaymentService _paymentService;

    public HomeController(IMassPaymentService massPaymentService, IAccountService accountService, IPaymentService paymentService)
    {
        _massPaymentService = massPaymentService;
        _accountService = accountService;
        _paymentService = paymentService;
    }

    public async Task<IActionResult> Index()
    {
        Ledger payoutLedger = new Ledger()
        {
            startDate = DateTime.Today.AddMonths(-6), // Bugünden 6 ay önce
            endDate = DateTime.Today.AddMonths(6),    // Bugünden 6 ay sonra
            page = 1,
            pageSize = 10,
            entryType = 9
        };
        var responsePayout = await _accountService.GetLedgers(payoutLedger);

        Ledger paymentLedger = new Ledger()
        {
            startDate = DateTime.Today.AddMonths(-6), // Bugünden 6 ay önce
            endDate = DateTime.Today.AddMonths(6),    // Bugünden 6 ay sonra
            page = 1,
            pageSize = 10,
            entryType = 8
        };
        var responsePayment = await _accountService.GetLedgers(paymentLedger);

        LedgerViewModel response = new LedgerViewModel()
        {
            PayoutLedgers = responsePayout,
            PaymentLedgers = responsePayment
        };
        return View(response);
    }

    public IActionResult MassPayment()
    {
        return View();
    }

    public IActionResult Payment()
    {
        return View();
    }


}
