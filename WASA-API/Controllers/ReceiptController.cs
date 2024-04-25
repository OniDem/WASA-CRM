﻿using Core.Const;
using Core.Entity;
using DTO.Receipt;
using DTO.User;
using Microsoft.AspNetCore.Mvc;
using Services;
using WASA_API.Service;

namespace WASA_API.Controllers
{
    [ApiController]
    [Route("[controller]/[action]")]
    public class ReceiptController : ControllerBase
    {

        private readonly ReceiptService _receiptService;

        public ReceiptController(ReceiptService receiptService)
        {
            _receiptService = receiptService;
        }

        [HttpPost]
        public async Task<ReceiptEntity?> Add([FromBody] AddReceiptRequest request)
        {
            if (ModelState.IsValid)
            {
                var receipt = await _receiptService.Add(request);
                return receipt;
            }
            return null;
        }

        [HttpPut]
        public async Task<ReceiptEntity?> Close([FromBody] int id)
        {
            if (ModelState.IsValid)
            {
                return await _receiptService.Close(id);
            }
            return null;
        }

        [HttpPut]
        public async Task<ReceiptEntity?> Payment(int id, PaymentReceiptRequest request)
        {
            if (ModelState.IsValid)
            {
                return await _receiptService.Payment(id, request);
            }
            return null;
        }

        [HttpPut]
        public async Task<ReceiptEntity?> Cancel(int id, CancelReasonEnum cancelReason)
        {
            if (ModelState.IsValid)
            {
                return await _receiptService.Cancel(id, cancelReason);
            }
            return null;
        }

        [HttpPut]
        public async Task<ReceiptEntity?> AgeConfirm(int id)
        {
            if(ModelState.IsValid)
            {
                return await _receiptService.AgeConfirm(id);
            }
            return null;
        }

        [HttpPut]
        public async Task<ReceiptEntity?> AddProducts(int id, List<string?> products)
        {
            if (ModelState.IsValid)
            {
                return await _receiptService.AddProducts(id, products);
            }
            return null;
        }

        [HttpPost]
        public async Task<ReceiptEntity?> ShowById([FromBody] int id)
        {
            if (ModelState.IsValid)
            {
                return await _receiptService.ShowById(id);
            }
            return null;    
        }

        [HttpPost]
        public async Task<List<ReceiptEntity>?> ShowCreatedByDate([FromBody] DateTime date)
        {
            if (ModelState.IsValid)
            {
                return await _receiptService.ShowCreatedByDate(date);
            }
            return null;
        }

        [HttpPost]
        public async Task<List<ReceiptEntity>?> ShowClosedByDate([FromBody] DateTime date)
        {
            if (ModelState.IsValid)
            {
                return await _receiptService.ShowClosedByDate(date);
            }
            return null;
        }

        [HttpPost]
        public async Task<List<ReceiptEntity>?> ShowPaymentByDate([FromBody] DateTime date)
        {
            if (ModelState.IsValid)
            {
                return await _receiptService.ShowPaymentByDate(date);
            }
            return null;
        }
    }
}