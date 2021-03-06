﻿using System;

namespace KillrVideo.Models.Videos
{
    /// <summary>
    /// Request for getting related videos.
    /// </summary>
    [Serializable]
    public class GetRelatedVideosViewModel
    {
        /// <summary>
        /// The video Id to get related videos for.
        /// </summary>
        public Guid VideoId { get; set; }

        /// <summary>
        /// The number of records per page.
        /// </summary>
        public int PageSize { get; set; }

        /// <summary>
        /// The current paging state. Will be null on initial load, then may have a value for subsequent pages.
        /// </summary>
        public string PagingState { get; set; }
    }
}