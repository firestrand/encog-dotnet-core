//
// Encog(tm) Core v3.1 - .Net Version
// http://www.heatonresearch.com/encog/
//
// Copyright 2008-2012 Heaton Research, Inc.
//
// Licensed under the Apache License, Version 2.0 (the "License");
// you may not use this file except in compliance with the License.
// You may obtain a copy of the License at
//
//  http://www.apache.org/licenses/LICENSE-2.0
//
// Unless required by applicable law or agreed to in writing, software
// distributed under the License is distributed on an "AS IS" BASIS,
// WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
// See the License for the specific language governing permissions and
// limitations under the License.
//   
// For more information on Heaton Research copyrights, licenses 
// and trademarks visit:
// http://www.heatonresearch.com/copyright
//
namespace Encog.Neural.Error
{
    /// <summary>
    /// An error function.  This is used to calculate the errors for the
    /// output layer during propagation training.
    /// </summary>
    public interface IErrorFunction
    {
        /// <summary>
        /// Calculate the error.
        /// </summary>
        /// <param name="ideal">The ideal values.</param>
        /// <param name="actual">The actual values.</param>
        /// <param name="error">The rror output.</param>
        void CalculateError(double[] ideal, double[] actual, double[] error);
    }
}
