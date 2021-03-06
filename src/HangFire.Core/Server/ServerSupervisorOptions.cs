// This file is part of HangFire.
// Copyright � 2013-2014 Sergey Odinokov.
// 
// HangFire is free software: you can redistribute it and/or modify
// it under the terms of the GNU Lesser General Public License as 
// published by the Free Software Foundation, either version 3 
// of the License, or any later version.
// 
// HangFire is distributed in the hope that it will be useful,
// but WITHOUT ANY WARRANTY; without even the implied warranty of
// MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
// GNU Lesser General Public License for more details.
// 
// You should have received a copy of the GNU Lesser General Public 
// License along with HangFire. If not, see <http://www.gnu.org/licenses/>.

using System;
using System.Threading;

namespace HangFire.Server
{
    public class ServerSupervisorOptions
    {
        private int _maxRetryAttempts;

        public ServerSupervisorOptions()
        {
            MaxRetryAttempts = 10;
            ShutdownTimeout = TimeSpan.FromMilliseconds(Timeout.Infinite);
            LowerLogVerbosity = false;
        }

        public int MaxRetryAttempts
        {
            get { return _maxRetryAttempts; }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentOutOfRangeException(
                        "value",
                        "MaxRetryAttempts property value must be greater or equal to 0.");
                }

                _maxRetryAttempts = value;
            }
        }

        public TimeSpan ShutdownTimeout { get; set; }
        public bool LowerLogVerbosity { get; set; }
    }
}