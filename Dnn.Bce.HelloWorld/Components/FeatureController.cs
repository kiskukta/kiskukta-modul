/*
' Copyright (c) 2026 Kiskukta
'  All rights reserved.
' 
' THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR IMPLIED, INCLUDING BUT NOT LIMITED
' TO THE WARRANTIES OF MERCHANTABILITY, FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL
' THE AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER LIABILITY, WHETHER IN AN ACTION OF
' CONTRACT, TORT OR OTHERWISE, ARISING FROM, OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER
' DEALINGS IN THE SOFTWARE.
' 
*/

using System.Collections.Generic;
//using System.Xml;
using DotNetNuke.Entities.Modules;
using DotNetNuke.Services.Search;

namespace Bce.Dnn.Dnn.Bce.HelloWorld.Components
{

    /// -----------------------------------------------------------------------------
    /// <summary>
    /// The Controller class for Dnn.Bce.HelloWorld
    /// 
    /// The FeatureController class is defined as the BusinessController in the manifest file (.dnn)
    /// DotNetNuke will poll this class to find out which Interfaces the class implements. 
    /// 
    /// The IPortable interface is used to import/export content from a DNN module
    /// 
    /// The ISearchable interface is used by DNN to index the content of a module
    /// 
    /// The IUpgradeable interface allows module developers to execute code during the upgrade 
    /// process for a module.
    /// 
    /// Below you will find stubbed out implementations of each, uncomment and populate with your own data
    /// </summary>
    /// -----------------------------------------------------------------------------

    //uncomment the interfaces to add the support.
    public class FeatureController //: IPortable, ISearchable, IUpgradeable
    {


        #region Optional Interfaces

        /// -----------------------------------------------------------------------------
        /// <summary>
        /// ExportModule implements the IPortable ExportModule Interface
        /// </summary>
        /// <param name="ModuleID">The Id of the module to be exported</param>
        /// -----------------------------------------------------------------------------
        //public string ExportModule(int ModuleID)
        //{
        //string strXML = "";

        //List<Dnn.Bce.HelloWorldInfo> colDnn.Bce.HelloWorlds = GetDnn.Bce.HelloWorlds(ModuleID);
        //if (colDnn.Bce.HelloWorlds.Count != 0)
        //{
        //    strXML += "<Dnn.Bce.HelloWorlds>";

        //    foreach (Dnn.Bce.HelloWorldInfo objDnn.Bce.HelloWorld in colDnn.Bce.HelloWorlds)
        //    {
        //        strXML += "<Dnn.Bce.HelloWorld>";
        //        strXML += "<content>" + DotNetNuke.Common.Utilities.XmlUtils.XMLEncode(objDnn.Bce.HelloWorld.Content) + "</content>";
        //        strXML += "</Dnn.Bce.HelloWorld>";
        //    }
        //    strXML += "</Dnn.Bce.HelloWorlds>";
        //}

        //return strXML;

        //	throw new System.NotImplementedException("The method or operation is not implemented.");
        //}

        /// -----------------------------------------------------------------------------
        /// <summary>
        /// ImportModule implements the IPortable ImportModule Interface
        /// </summary>
        /// <param name="ModuleID">The Id of the module to be imported</param>
        /// <param name="Content">The content to be imported</param>
        /// <param name="Version">The version of the module to be imported</param>
        /// <param name="UserId">The Id of the user performing the import</param>
        /// -----------------------------------------------------------------------------
        //public void ImportModule(int ModuleID, string Content, string Version, int UserID)
        //{
        //XmlNode xmlDnn.Bce.HelloWorlds = DotNetNuke.Common.Globals.GetContent(Content, "Dnn.Bce.HelloWorlds");
        //foreach (XmlNode xmlDnn.Bce.HelloWorld in xmlDnn.Bce.HelloWorlds.SelectNodes("Dnn.Bce.HelloWorld"))
        //{
        //    Dnn.Bce.HelloWorldInfo objDnn.Bce.HelloWorld = new Dnn.Bce.HelloWorldInfo();
        //    objDnn.Bce.HelloWorld.ModuleId = ModuleID;
        //    objDnn.Bce.HelloWorld.Content = xmlDnn.Bce.HelloWorld.SelectSingleNode("content").InnerText;
        //    objDnn.Bce.HelloWorld.CreatedByUser = UserID;
        //    AddDnn.Bce.HelloWorld(objDnn.Bce.HelloWorld);
        //}

        //	throw new System.NotImplementedException("The method or operation is not implemented.");
        //}

        /// -----------------------------------------------------------------------------
        /// <summary>
        /// GetSearchItems implements the ISearchable Interface
        /// </summary>
        /// <param name="ModInfo">The ModuleInfo for the module to be Indexed</param>
        /// -----------------------------------------------------------------------------
        //public DotNetNuke.Services.Search.SearchItemInfoCollection GetSearchItems(DotNetNuke.Entities.Modules.ModuleInfo ModInfo)
        //{
        //SearchItemInfoCollection SearchItemCollection = new SearchItemInfoCollection();

        //List<Dnn.Bce.HelloWorldInfo> colDnn.Bce.HelloWorlds = GetDnn.Bce.HelloWorlds(ModInfo.ModuleID);

        //foreach (Dnn.Bce.HelloWorldInfo objDnn.Bce.HelloWorld in colDnn.Bce.HelloWorlds)
        //{
        //    SearchItemInfo SearchItem = new SearchItemInfo(ModInfo.ModuleTitle, objDnn.Bce.HelloWorld.Content, objDnn.Bce.HelloWorld.CreatedByUser, objDnn.Bce.HelloWorld.CreatedDate, ModInfo.ModuleID, objDnn.Bce.HelloWorld.ItemId.ToString(), objDnn.Bce.HelloWorld.Content, "ItemId=" + objDnn.Bce.HelloWorld.ItemId.ToString());
        //    SearchItemCollection.Add(SearchItem);
        //}

        //return SearchItemCollection;

        //	throw new System.NotImplementedException("The method or operation is not implemented.");
        //}

        /// -----------------------------------------------------------------------------
        /// <summary>
        /// UpgradeModule implements the IUpgradeable Interface
        /// </summary>
        /// <param name="Version">The current version of the module</param>
        /// -----------------------------------------------------------------------------
        //public string UpgradeModule(string Version)
        //{
        //	throw new System.NotImplementedException("The method or operation is not implemented.");
        //}

        #endregion

    }

}
