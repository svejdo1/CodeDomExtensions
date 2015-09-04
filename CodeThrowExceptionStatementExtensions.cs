﻿#region License
//  Copyright 2004-2010 Castle Project - http:www.castleproject.org/
//  
//  Licensed under the Apache License, Version 2.0 (the "License");
//  you may not use this file except in compliance with the License.
//  You may obtain a copy of the License at
//  
//      http:www.apache.org/licenses/LICENSE-2.0
//  
//  Unless required by applicable law or agreed to in writing, software
//  distributed under the License is distributed on an "AS IS" BASIS,
//  WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
//  See the License for the specific language governing permissions and
//  limitations under the License.
// 
#endregion

namespace Castle.ActiveWriter.CodeDomExtensions
{
	using System.CodeDom;

	public static class CodeThrowExceptionStatementExtensions
    {
        public static CodeThrowExceptionStatement Clone(this CodeThrowExceptionStatement statement)
        {
            if (statement == null) return null;
            CodeThrowExceptionStatement s = new CodeThrowExceptionStatement();
            s.EndDirectives.AddRange(statement.EndDirectives);
            s.LinePragma = statement.LinePragma;
            s.StartDirectives.AddRange(statement.StartDirectives);
            s.ToThrow = statement.ToThrow.Clone();
            s.UserData.AddRange(statement.UserData);
            return s;
        }

        public static void ReplaceType(this CodeThrowExceptionStatement statement, string oldType, string newType)
        {
            if (statement == null) return;
            statement.ToThrow.ReplaceType(oldType, newType);
        }
    }
}
