﻿/********************************************************************************
Copyright (C) Binod Nepal, Mix Open Foundation (http://mixof.org).

This file is part of MixERP.

MixERP is free software: you can redistribute it and/or modify
it under the terms of the GNU General Public License as published by
the Free Software Foundation, either version 3 of the License, or
(at your option) any later version.

MixERP is distributed in the hope that it will be useful,
but WITHOUT ANY WARRANTY; without even the implied warranty of
MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
GNU General Public License for more details.

You should have received a copy of the GNU General Public License
along with MixERP.  If not, see <http://www.gnu.org/licenses/>.
***********************************************************************************/

using System;

namespace MixERP.Net.Common.Models.Office
{
    [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1724:TypeNamesShouldNotMatchNamespaces")]
    public sealed class Office
    {
        public string AddressLine1 { get; set; }

        public string AddressLine2 { get; set; }

        public string City { get; set; }

        public string Country { get; set; }

        public string CurrencyCode { get; set; }

        public string Email { get; set; }

        public string Fax { get; set; }

        public string Nickname { get; set; }

        public string OfficeCode { get; set; }

        public int OfficeId { get; set; }

        public string OfficeName { get; set; }

        public string PanNumber { get; set; }

        public Office ParentOffice { get; set; }

        public int? ParentOfficeId { get; set; }

        public string Phone { get; set; }

        public DateTime RegistrationDate { get; set; }

        public string RegistrationNumber { get; set; }

        public string State { get; set; }

        public string Street { get; set; }

        public Uri Url { get; set; }

        public string ZipCode { get; set; }
    }
}