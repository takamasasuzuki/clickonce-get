﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Runtime.Serialization;
using System.Web;
using System.Web.Mvc;

namespace ClickOnceGet.Models
{
    [DataContract]
    public class ClickOnceAppInfo
    {
        [DataMember, AllowHtml]
        public string Name { get; set; }

        public string OwnerId { get; set; }

        [DataMember]
        public DateTime RegisteredAt { get; set; }

        [DataMember, StringLength(140), AllowHtml]
        public string Title { get; set; }

        [DataMember, StringLength(140), AllowHtml]
        public string Description { get; set; }

        [DataMember, Url]
        public string ProjectURL { get; set; }

        [DataMember, AllowHtml]
        public string PublisherName { get; set; }

        [DataMember]
        public string PublisherAvatorImageURL { get; set; }

        [DataMember]
        public string PublisherURL { get; set; }

        [DataMember]
        public int NumberOfDownloads { get; set; }

        [DataMember]
        public bool? HasCodeSigning { get; set; }

        [DataMember]
        public bool SignedByPublisher { get; set; }

        public string GetTitleOrName()
        {
            return string.IsNullOrEmpty(this.Title) ? this.Name : this.Title;
        }
    }
}