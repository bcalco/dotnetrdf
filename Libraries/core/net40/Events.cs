/*
dotNetRDF is free and open source software licensed under the MIT License

-----------------------------------------------------------------------------

Copyright (c) 2009-2012 dotNetRDF Project (dotnetrdf-developer@lists.sf.net)

Permission is hereby granted, free of charge, to any person obtaining a copy
of this software and associated documentation files (the "Software"), to deal
in the Software without restriction, including without limitation the rights
to use, copy, modify, merge, publish, distribute, sublicense, and/or sell
copies of the Software, and to permit persons to whom the Software is furnished
to do so, subject to the following conditions:

The above copyright notice and this permission notice shall be included in all
copies or substantial portions of the Software.

THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR 
IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY, 
FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE
AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER LIABILITY,
WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM, OUT OF OR IN
CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN THE SOFTWARE.
*/

using System;
using System.Collections.Specialized;
using VDS.RDF.Graphs;
using VDS.RDF.Nodes;

namespace VDS.RDF
{
    #region Reader and Writer Warning Events

    // TODO Refactor events to have a nicer signature

    /// <summary>
    /// Delegate Type for Warning Messages raised by RDF Readers
    /// </summary>
    /// <param name="warning">Warning Message</param>
    public delegate void RdfReaderWarning(String warning);

    /// <summary>
    /// Delegate Type for Warning Messages raised by RDF Writers
    /// </summary>
    /// <param name="message">Warning Message</param>
    public delegate void RdfWriterWarning(String message);

    /// <summary>
    /// Delegate Type for Warning Events raised by SPARQL Readers and Writers for Queries, Updates and Results
    /// </summary>
    /// <param name="message">Warning Message</param>
    public delegate void SparqlWarning(String message);

    #endregion

}
