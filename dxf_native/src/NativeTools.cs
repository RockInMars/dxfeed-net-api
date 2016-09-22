﻿/// Copyright (C) 2010-2016 Devexperts LLC
///
/// This Source Code Form is subject to the terms of the Mozilla Public License, v. 2.0.
/// If a copy of the MPL was not distributed with this file, You can obtain one at
/// http://mozilla.org/MPL/2.0/.

using com.dxfeed.native.api;

namespace com.dxfeed.native
{
    public class NativeTools
    {
        public static void InitializeLogging(string fileName, bool overwrite, bool verbose)
        {
            C.CheckOk(C.Instance.dxf_initialize_logger(fileName, overwrite, true, verbose));
        }
    }
}
