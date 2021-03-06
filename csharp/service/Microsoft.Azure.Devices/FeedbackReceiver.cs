﻿// Copyright (c) Microsoft. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

namespace Microsoft.Azure.Devices
{
    public abstract class FeedbackReceiver<T> : Receiver<T> where T: FeedbackBatch
    {
    }
}
