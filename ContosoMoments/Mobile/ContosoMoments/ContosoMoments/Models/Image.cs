﻿using Microsoft.WindowsAzure.MobileServices;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace ContosoMoments.Models
{
    public class Image
    {
        Guid id;
        Guid imageId;
        string imageFormat;
        string containerName;
        Guid albumId;
        Guid userId;

        [JsonProperty(PropertyName = "Id")]
        public Guid Id
        {
            get { return id; }
            set { id = value; }
        }

        [JsonProperty(PropertyName = "ImageId")]
        public Guid ImageId
        {
            get { return imageId; }
            set { imageId = value; }
        }

        [JsonProperty(PropertyName = "ImageFormat")]
        public string ImageFormat
        {
            get { return imageFormat; }
            set { imageFormat = value; }
        }

        [JsonProperty(PropertyName = "ContainerName")]
        public string ContainerName
        {
            get { return containerName; }
            set { containerName = value; }
        }

        [JsonProperty(PropertyName = "AlbumId")]
        public Guid AlbumId
        {
            get { return albumId; }
            set { albumId = value; }
        }

        [JsonProperty(PropertyName = "UserId")]
        public Guid UserId
        {
            get { return userId; }
            set { userId = value; }
        }

        [JsonIgnore]
        public IDictionary<string, Uri> ImagePath
        {
            get
            {
                Dictionary<string, Uri> retVal = new Dictionary<string, Uri>();

                retVal.Add("xs", new Uri(string.Format("{0}/xs/{1}.jpg", containerName, imageId.ToString())));
                retVal.Add("sm", new Uri(string.Format("{0}/sm/{1}.jpg", containerName, imageId.ToString())));
                retVal.Add("md", new Uri(string.Format("{0}/md/{1}.jpg", containerName, imageId.ToString())));
                retVal.Add("lg", new Uri(string.Format("{0}/lg/{1}.jpg", containerName, imageId.ToString())));

                return retVal;
            }
        }

        [Version]
        public string Version { get; set; }

    }
}
