/*
 * Copyright 2016 e-UCM (http://www.e-ucm.es/)
 * 
 * Licensed under the Apache License, Version 2.0 (the "License");
 * you may not use this file except in compliance with the License.
 * This project has received funding from the European Union’s Horizon
 * 2020 research and innovation programme under grant agreement No 644187.
 * You may obtain a copy of the License at
 * 
 *     http://www.apache.org/licenses/LICENSE-2.0 (link is external)
 * 
 * Unless required by applicable law or agreed to in writing, software
 * distributed under the License is distributed on an "AS IS" BASIS,
 * WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
 * See the License for the specific language governing permissions and
 * limitations under the License.
 */
// ------------------------------------------------------------------------------
//  <autogenerated>
//      This code was generated by a tool.
//      Mono Runtime Version: 4.0.30319.17020
// 
//      Changes to this file may cause incorrect behavior and will be lost if 
//      the code is regenerated.
//  </autogenerated>
// ------------------------------------------------------------------------------
using System;
using System.Collections.Generic;
using SimpleJSON;

public class SimpleJsonFormat : Tracker.ITraceFormatter
{

	public string Serialize (List<string> traces)
	{
		String result = "[";	
		foreach (String trace in traces){
			string[] parts = trace.Split(',');
			result += "{\"event\":\"" + parts[1] + "\", " +
				"\"target\":\"" + parts[2] + "\"" +
				( parts.Length == 4 ? ",\"value\":\"" + parts[3] + "\"" : "")
				+ "},";
		}
		return result.Substring(0, result.Length - 1) + "]";
	}

    public void StartData(JSONNode data)
    {

    }
}


