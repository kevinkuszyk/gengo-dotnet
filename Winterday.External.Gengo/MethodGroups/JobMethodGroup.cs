﻿//
// JobEndpoint.cs
//
// Author:
//       Jarl Erik Schmidt <github@jarlerik.com>
//
// Copyright (c) 2013 Jarl Erik Schmidt
//
// Permission is hereby granted, free of charge, to any person obtaining a copy
// of this software and associated documentation files (the "Software"), to deal
// in the Software without restriction, including without limitation the rights
// to use, copy, modify, merge, publish, distribute, sublicense, and/or sell
// copies of the Software, and to permit persons to whom the Software is
// furnished to do so, subject to the following conditions:
//
// The above copyright notice and this permission notice shall be included in
// all copies or substantial portions of the Software.
//
// THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR
// IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY,
// FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE
// AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER
// LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM,
// OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN
// THE SOFTWARE.

namespace Winterday.External.Gengo.Endpoints
{
    using System;
    using System.Threading.Tasks;

    using Winterday.External.Gengo.Payloads;

    public class JobEndpoint
    {
        readonly IGengoClient _client;

        internal JobEndpoint(IGengoClient client)
        {
            if (client == null)
                throw new ArgumentNullException("client");

            _client = client;
        }

        public async Task Approve(int jobId, Stars stars,
            string commentForTranslator,
            string commentForGengo,
            bool gengoCommentIsPublic)
        {
            throw new NotImplementedException();
        }

        public async Task<SubmittedJob> Get(int jobId)
        {
            throw new NotImplementedException();
        }

        public async Task<byte[]> GetPreviewImage(int jobId)
        {
            throw new NotImplementedException();
        }

        public async Task Reject(int jobId, RejectionReason reason,
            string comment, string captcha, bool requeueJob)
        {
            throw new NotImplementedException();
        }

        public async Task Revise(int jobId, string comment)
        {
            throw new NotImplementedException();
        }

        public async Task Delete(int jobId)
        {
            throw new NotImplementedException();
        }

    }
}