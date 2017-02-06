// ------------------------------------------------------------------------------
//  <autogenerated>
//      This code was generated by a tool.
//      Mono Runtime Version: 4.0.30319.17020
// 
//      Changes to this file may cause incorrect behavior and will be lost if 
//      the code is regenerated.
//  </autogenerated>
// ------------------------------------------------------------------------------

namespace Hamekoz.Argentina.Afip.WSDL {
    using System.Diagnostics;
    using System;
    using System.Xml.Serialization;
    using System.ComponentModel;
    using System.Web.Services.Protocols;
    using System.Web.Services;
    
    
    /// CodeRemarks
    [System.CodeDom.Compiler.GeneratedCodeAttribute("MonoDevelop", "2.6.0.0")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Web.Services.WebServiceBindingAttribute(Name="ServiceSoap", Namespace="http://servicios1.afip.gob.ar/wscdc/")]
    public partial class Service : System.Web.Services.Protocols.SoapHttpClientProtocol {
        
        /// CodeRemarks
        public Service() {
            this.Url = "https://servicios1.afip.gov.ar/WSCDC/service.asmx";
        }
        
        public Service(string url) {
            this.Url = url;
        }
        
        /// CodeRemarks
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://servicios1.afip.gob.ar/wscdc/ComprobantesModalidadConsultar", RequestNamespace="http://servicios1.afip.gob.ar/wscdc/", ResponseNamespace="http://servicios1.afip.gob.ar/wscdc/", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        public FacModTipoResponse ComprobantesModalidadConsultar(CmpAuthRequest Auth) {
            object[] results = this.Invoke("ComprobantesModalidadConsultar", new object[] {
                        Auth});
            return ((FacModTipoResponse)(results[0]));
        }
        
        /// CodeRemarks
        public System.IAsyncResult BeginComprobantesModalidadConsultar(CmpAuthRequest Auth, System.AsyncCallback callback, object asyncState) {
            return this.BeginInvoke("ComprobantesModalidadConsultar", new object[] {
                        Auth}, callback, asyncState);
        }
        
        /// CodeRemarks
        public FacModTipoResponse EndComprobantesModalidadConsultar(System.IAsyncResult asyncResult) {
            object[] results = this.EndInvoke(asyncResult);
            return ((FacModTipoResponse)(results[0]));
        }
        
        /// CodeRemarks
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://servicios1.afip.gob.ar/wscdc/ComprobantesTipoConsultar", RequestNamespace="http://servicios1.afip.gob.ar/wscdc/", ResponseNamespace="http://servicios1.afip.gob.ar/wscdc/", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        public CbteTipoResponse ComprobantesTipoConsultar(CmpAuthRequest Auth) {
            object[] results = this.Invoke("ComprobantesTipoConsultar", new object[] {
                        Auth});
            return ((CbteTipoResponse)(results[0]));
        }
        
        /// CodeRemarks
        public System.IAsyncResult BeginComprobantesTipoConsultar(CmpAuthRequest Auth, System.AsyncCallback callback, object asyncState) {
            return this.BeginInvoke("ComprobantesTipoConsultar", new object[] {
                        Auth}, callback, asyncState);
        }
        
        /// CodeRemarks
        public CbteTipoResponse EndComprobantesTipoConsultar(System.IAsyncResult asyncResult) {
            object[] results = this.EndInvoke(asyncResult);
            return ((CbteTipoResponse)(results[0]));
        }
        
        /// CodeRemarks
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://servicios1.afip.gob.ar/wscdc/DocumentosTipoConsultar", RequestNamespace="http://servicios1.afip.gob.ar/wscdc/", ResponseNamespace="http://servicios1.afip.gob.ar/wscdc/", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        public DocTipoResponse DocumentosTipoConsultar(CmpAuthRequest Auth) {
            object[] results = this.Invoke("DocumentosTipoConsultar", new object[] {
                        Auth});
            return ((DocTipoResponse)(results[0]));
        }
        
        /// CodeRemarks
        public System.IAsyncResult BeginDocumentosTipoConsultar(CmpAuthRequest Auth, System.AsyncCallback callback, object asyncState) {
            return this.BeginInvoke("DocumentosTipoConsultar", new object[] {
                        Auth}, callback, asyncState);
        }
        
        /// CodeRemarks
        public DocTipoResponse EndDocumentosTipoConsultar(System.IAsyncResult asyncResult) {
            object[] results = this.EndInvoke(asyncResult);
            return ((DocTipoResponse)(results[0]));
        }
        
        /// CodeRemarks
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://servicios1.afip.gob.ar/wscdc/OpcionalesTipoConsultar", RequestNamespace="http://servicios1.afip.gob.ar/wscdc/", ResponseNamespace="http://servicios1.afip.gob.ar/wscdc/", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        public OpcionalTipoResponse OpcionalesTipoConsultar(CmpAuthRequest Auth) {
            object[] results = this.Invoke("OpcionalesTipoConsultar", new object[] {
                        Auth});
            return ((OpcionalTipoResponse)(results[0]));
        }
        
        /// CodeRemarks
        public System.IAsyncResult BeginOpcionalesTipoConsultar(CmpAuthRequest Auth, System.AsyncCallback callback, object asyncState) {
            return this.BeginInvoke("OpcionalesTipoConsultar", new object[] {
                        Auth}, callback, asyncState);
        }
        
        /// CodeRemarks
        public OpcionalTipoResponse EndOpcionalesTipoConsultar(System.IAsyncResult asyncResult) {
            object[] results = this.EndInvoke(asyncResult);
            return ((OpcionalTipoResponse)(results[0]));
        }
        
        /// CodeRemarks
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://servicios1.afip.gob.ar/wscdc/ComprobanteConstatar", RequestNamespace="http://servicios1.afip.gob.ar/wscdc/", ResponseNamespace="http://servicios1.afip.gob.ar/wscdc/", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        public CmpResponse ComprobanteConstatar(CmpAuthRequest Auth, CmpDatos CmpReq) {
            object[] results = this.Invoke("ComprobanteConstatar", new object[] {
                        Auth,
                        CmpReq});
            return ((CmpResponse)(results[0]));
        }
        
        /// CodeRemarks
        public System.IAsyncResult BeginComprobanteConstatar(CmpAuthRequest Auth, CmpDatos CmpReq, System.AsyncCallback callback, object asyncState) {
            return this.BeginInvoke("ComprobanteConstatar", new object[] {
                        Auth,
                        CmpReq}, callback, asyncState);
        }
        
        /// CodeRemarks
        public CmpResponse EndComprobanteConstatar(System.IAsyncResult asyncResult) {
            object[] results = this.EndInvoke(asyncResult);
            return ((CmpResponse)(results[0]));
        }
        
        /// CodeRemarks
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://servicios1.afip.gob.ar/wscdc/ComprobanteDummy", RequestNamespace="http://servicios1.afip.gob.ar/wscdc/", ResponseNamespace="http://servicios1.afip.gob.ar/wscdc/", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        public DummyResponse ComprobanteDummy() {
            object[] results = this.Invoke("ComprobanteDummy", new object[0]);
            return ((DummyResponse)(results[0]));
        }
        
        /// CodeRemarks
        public System.IAsyncResult BeginComprobanteDummy(System.AsyncCallback callback, object asyncState) {
            return this.BeginInvoke("ComprobanteDummy", new object[0], callback, asyncState);
        }
        
        /// CodeRemarks
        public DummyResponse EndComprobanteDummy(System.IAsyncResult asyncResult) {
            object[] results = this.EndInvoke(asyncResult);
            return ((DummyResponse)(results[0]));
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("MonoDevelop", "2.6.0.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://servicios1.afip.gob.ar/wscdc/")]
    public partial class CmpAuthRequest {
        
        /// <remarks/>
        public string Token;
        
        /// <remarks/>
        public string Sign;
        
        /// <remarks/>
        public long Cuit;
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("MonoDevelop", "2.6.0.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://servicios1.afip.gob.ar/wscdc/")]
    public partial class DummyResponse {
        
        /// <remarks/>
        public string AppServer;
        
        /// <remarks/>
        public string DbServer;
        
        /// <remarks/>
        public string AuthServer;
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("MonoDevelop", "2.6.0.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://servicios1.afip.gob.ar/wscdc/")]
    public partial class Obs {
        
        /// <remarks/>
        public int Code;
        
        /// <remarks/>
        public string Msg;
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("MonoDevelop", "2.6.0.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://servicios1.afip.gob.ar/wscdc/")]
    public partial class CmpResponse {
        
        /// <remarks/>
        public CmpDatos CmpResp;
        
        /// <remarks/>
        public string Resultado;
        
        /// <remarks/>
        public Obs[] Observaciones;
        
        /// <remarks/>
        public string FchProceso;
        
        /// <remarks/>
        public Evt[] Events;
        
        /// <remarks/>
        public Err[] Errors;
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("MonoDevelop", "2.6.0.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://servicios1.afip.gob.ar/wscdc/")]
    public partial class CmpDatos {
        
        /// <remarks/>
        public string CbteModo;
        
        /// <remarks/>
        public long CuitEmisor;
        
        /// <remarks/>
        public int PtoVta;
        
        /// <remarks/>
        public int CbteTipo;
        
        /// <remarks/>
        public long CbteNro;
        
        /// <remarks/>
        public string CbteFch;
        
        /// <remarks/>
        public double ImpTotal;
        
        /// <remarks/>
        public string CodAutorizacion;
        
        /// <remarks/>
        public string DocTipoReceptor;
        
        /// <remarks/>
        public string DocNroReceptor;
        
        /// <remarks/>
        public Opcional[] Opcionales;
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("MonoDevelop", "2.6.0.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://servicios1.afip.gob.ar/wscdc/")]
    public partial class Opcional {
        
        /// <remarks/>
        public string Id;
        
        /// <remarks/>
        public string Valor;
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("MonoDevelop", "2.6.0.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://servicios1.afip.gob.ar/wscdc/")]
    public partial class Evt {
        
        /// <remarks/>
        public int Code;
        
        /// <remarks/>
        public string Msg;
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("MonoDevelop", "2.6.0.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://servicios1.afip.gob.ar/wscdc/")]
    public partial class Err {
        
        /// <remarks/>
        public int Code;
        
        /// <remarks/>
        public string Msg;
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("MonoDevelop", "2.6.0.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://servicios1.afip.gob.ar/wscdc/")]
    public partial class OpcionalTipo {
        
        /// <remarks/>
        public string Id;
        
        /// <remarks/>
        public string Desc;
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("MonoDevelop", "2.6.0.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://servicios1.afip.gob.ar/wscdc/")]
    public partial class OpcionalTipoResponse {
        
        /// <remarks/>
        public OpcionalTipo[] ResultGet;
        
        /// <remarks/>
        public Err[] Errors;
        
        /// <remarks/>
        public Evt[] Events;
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("MonoDevelop", "2.6.0.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://servicios1.afip.gob.ar/wscdc/")]
    public partial class DocTipo {
        
        /// <remarks/>
        public string Id;
        
        /// <remarks/>
        public string Desc;
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("MonoDevelop", "2.6.0.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://servicios1.afip.gob.ar/wscdc/")]
    public partial class DocTipoResponse {
        
        /// <remarks/>
        public DocTipo[] ResultGet;
        
        /// <remarks/>
        public Err[] Errors;
        
        /// <remarks/>
        public Evt[] Events;
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("MonoDevelop", "2.6.0.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://servicios1.afip.gob.ar/wscdc/")]
    public partial class CbteTipo {
        
        /// <remarks/>
        public int Id;
        
        /// <remarks/>
        public string Desc;
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("MonoDevelop", "2.6.0.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://servicios1.afip.gob.ar/wscdc/")]
    public partial class CbteTipoResponse {
        
        /// <remarks/>
        public CbteTipo[] ResultGet;
        
        /// <remarks/>
        public Err[] Errors;
        
        /// <remarks/>
        public Evt[] Events;
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("MonoDevelop", "2.6.0.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://servicios1.afip.gob.ar/wscdc/")]
    public partial class FacModTipo {
        
        /// <remarks/>
        public string Cod;
        
        /// <remarks/>
        public string Desc;
        
        /// <remarks/>
        public string FchDesde;
        
        /// <remarks/>
        public string FchHasta;
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("MonoDevelop", "2.6.0.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://servicios1.afip.gob.ar/wscdc/")]
    public partial class FacModTipoResponse {
        
        /// <remarks/>
        public FacModTipo[] ResultGet;
        
        /// <remarks/>
        public Err[] Errors;
        
        /// <remarks/>
        public Evt[] Events;
    }
}
