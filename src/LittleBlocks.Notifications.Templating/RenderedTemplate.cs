﻿// This software is part of the LittleBlocks framework
// Copyright (C) 2019 LittleBlocks
//
// This program is free software: you can redistribute it and/or modify
// it under the terms of the GNU Affero General Public License as published by
// the Free Software Foundation, either version 3 of the License, or
// (at your option) any later version.
//
// This program is distributed in the hope that it will be useful,
// but WITHOUT ANY WARRANTY; without even the implied warranty of
// MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
// GNU Affero General Public License for more details.
//
// You should have received a copy of the GNU Affero General Public License
// along with this program.  If not, see <http://www.gnu.org/licenses/>.

namespace LittleBlocks.Notifications.Templating;

public sealed class RenderedTemplate<T> where T : class
{
    public RenderedTemplate(string content, T data)
    {
        if (string.IsNullOrWhiteSpace(content))
            throw new ArgumentException("Value cannot be null or whitespace.", nameof(content));

        Data = data ?? throw new ArgumentNullException(nameof(data));
        Content = content;
    }

    public string Content { get; }
    public T Data { get; }
}
