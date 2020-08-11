// Copyright 2020, Google Inc. All rights reserved.
//
// Licensed under the Apache License, Version 2.0 (the "License");
// you may not use this file except in compliance with the License.
// You may obtain a copy of the License at
//
//     http://www.apache.org/licenses/LICENSE-2.0
//
// Unless required by applicable law or agreed to in writing, software
// distributed under the License is distributed on an "AS IS" BASIS,
// WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
// See the License for the specific language governing permissions and
// limitations under the License.

using System;
using Xunit;

namespace FirebaseAdmin.Auth.Tests
{
    public class UserIdentifierTest
    {
        [Fact]
        public void InvalidUidIdentifier()
        {
            Assert.Throws<ArgumentException>(
                () => new UidIdentifier("too long " + new string('.', 128)));
        }

        [Fact]
        public void InvalidEmailIdentifier()
        {
            Assert.Throws<ArgumentException>(
                    () => new EmailIdentifier("invalid email addr"));
        }

        [Fact]
        public void InvalidPhoneIdentifier()
        {
            Assert.Throws<ArgumentException>(
                    () => new PhoneIdentifier("invalid phone number"));
        }

        [Fact]
        public void InvalidProviderIdentifier()
        {
            Assert.Throws<ArgumentException>(
                    () => new ProviderIdentifier(string.Empty, "valid-uid"));

            Assert.Throws<ArgumentException>(
                    () => new ProviderIdentifier("valid-id", string.Empty));
        }
    }
}
