﻿using Grand.Infrastructure.ModelBinding;
using Grand.Infrastructure.Models;
using Microsoft.AspNetCore.Mvc.Rendering;
using System.ComponentModel.DataAnnotations;

namespace Grand.Web.Admin.Models.Affiliates
{
    public class AffiliatedOrderListModel : BaseModel
    {
        public string AffliateId { get; set; }

        [GrandResourceDisplayName("Admin.Affiliates.Orders.StartDate")]
        [UIHint("DateNullable")]
        public DateTime? StartDate { get; set; }

        [GrandResourceDisplayName("Admin.Affiliates.Orders.EndDate")]
        [UIHint("DateNullable")]
        public DateTime? EndDate { get; set; }

        [GrandResourceDisplayName("Admin.Affiliates.Orders.OrderStatus")]
        public int OrderStatusId { get; set; }
        [GrandResourceDisplayName("Admin.Affiliates.Orders.PaymentStatus")]
        public int PaymentStatusId { get; set; }
        [GrandResourceDisplayName("Admin.Affiliates.Orders.ShippingStatus")]
        public int ShippingStatusId { get; set; }

        public IList<SelectListItem> AvailableOrderStatuses { get; set; } = new List<SelectListItem>();
        public IList<SelectListItem> AvailablePaymentStatuses { get; set; } = new List<SelectListItem>();
        public IList<SelectListItem> AvailableShippingStatuses { get; set; } = new List<SelectListItem>();
    }
}