﻿using System;

namespace Requests.Core
{
    public interface IHttpRequester
    {
        Task<HttpResponseMessage?> GetAsync(
            Uri uri,
            string userAgent,
            string userAccepts,
            CancellationToken cancellationToken);
    }
}
