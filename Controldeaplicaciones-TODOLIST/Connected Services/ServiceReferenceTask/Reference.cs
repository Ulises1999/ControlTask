﻿//------------------------------------------------------------------------------
// <auto-generated>
//     Este código fue generado por una herramienta.
//     Versión de runtime:4.0.30319.42000
//
//     Los cambios en este archivo podrían causar un comportamiento incorrecto y se perderán si
//     se vuelve a generar el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Controldeaplicaciones_TODOLIST.ServiceReferenceTask {
    using System.Runtime.Serialization;
    using System;

    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="Task", Namespace="http://schemas.datacontract.org/2004/07/WcfTask")]
    [System.SerializableAttribute()]
    public partial class Task : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int EstadoField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private System.DateTime FechacreField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private System.DateTime FechaterField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int IdField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string NombreField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string NotaField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string PrioridadField;
        
        [global::System.ComponentModel.BrowsableAttribute(false)]
        public System.Runtime.Serialization.ExtensionDataObject ExtensionData {
            get {
                return this.extensionDataField;
            }
            set {
                this.extensionDataField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int Estado {
            get {
                return this.EstadoField;
            }
            set {
                if ((this.EstadoField.Equals(value) != true)) {
                    this.EstadoField = value;
                    this.RaisePropertyChanged("Estado");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public System.DateTime Fechacre {
            get {
                return this.FechacreField;
            }
            set {
                if ((this.FechacreField.Equals(value) != true)) {
                    this.FechacreField = value;
                    this.RaisePropertyChanged("Fechacre");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public System.DateTime Fechater {
            get {
                return this.FechaterField;
            }
            set {
                if ((this.FechaterField.Equals(value) != true)) {
                    this.FechaterField = value;
                    this.RaisePropertyChanged("Fechater");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int Id {
            get {
                return this.IdField;
            }
            set {
                if ((this.IdField.Equals(value) != true)) {
                    this.IdField = value;
                    this.RaisePropertyChanged("Id");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Nombre {
            get {
                return this.NombreField;
            }
            set {
                if ((object.ReferenceEquals(this.NombreField, value) != true)) {
                    this.NombreField = value;
                    this.RaisePropertyChanged("Nombre");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Nota {
            get {
                return this.NotaField;
            }
            set {
                if ((object.ReferenceEquals(this.NotaField, value) != true)) {
                    this.NotaField = value;
                    this.RaisePropertyChanged("Nota");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Prioridad {
            get {
                return this.PrioridadField;
            }
            set {
                if ((object.ReferenceEquals(this.PrioridadField, value) != true)) {
                    this.PrioridadField = value;
                    this.RaisePropertyChanged("Prioridad");
                }
            }
        }
        
        public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;
        
        protected void RaisePropertyChanged(string propertyName) {
            System.ComponentModel.PropertyChangedEventHandler propertyChanged = this.PropertyChanged;
            if ((propertyChanged != null)) {
                propertyChanged(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
            }
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="ServiceReferenceTask.ITask")]
    public interface ITask {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ITask/GetTasks", ReplyAction="http://tempuri.org/ITask/GetTasksResponse")]
        Controldeaplicaciones_TODOLIST.ServiceReferenceTask.Task[] GetTasks();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ITask/GetTasks", ReplyAction="http://tempuri.org/ITask/GetTasksResponse")]
        System.Threading.Tasks.Task<Controldeaplicaciones_TODOLIST.ServiceReferenceTask.Task[]> GetTasksAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ITask/ListPriority", ReplyAction="http://tempuri.org/ITask/ListPriorityResponse")]
        Controldeaplicaciones_TODOLIST.ServiceReferenceTask.Task[] ListPriority(string filtro);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ITask/ListPriority", ReplyAction="http://tempuri.org/ITask/ListPriorityResponse")]
        System.Threading.Tasks.Task<Controldeaplicaciones_TODOLIST.ServiceReferenceTask.Task[]> ListPriorityAsync(string filtro);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ITask/ListId", ReplyAction="http://tempuri.org/ITask/ListIdResponse")]
        Controldeaplicaciones_TODOLIST.ServiceReferenceTask.Task[] ListId(int id);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ITask/ListId", ReplyAction="http://tempuri.org/ITask/ListIdResponse")]
        System.Threading.Tasks.Task<Controldeaplicaciones_TODOLIST.ServiceReferenceTask.Task[]> ListIdAsync(int id);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ITask/InsertTask", ReplyAction="http://tempuri.org/ITask/InsertTaskResponse")]
        void InsertTask(Controldeaplicaciones_TODOLIST.ServiceReferenceTask.Task task);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ITask/InsertTask", ReplyAction="http://tempuri.org/ITask/InsertTaskResponse")]
        System.Threading.Tasks.Task InsertTaskAsync(Controldeaplicaciones_TODOLIST.ServiceReferenceTask.Task task);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ITask/EditTask", ReplyAction="http://tempuri.org/ITask/EditTaskResponse")]
        void EditTask(Controldeaplicaciones_TODOLIST.ServiceReferenceTask.Task task);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ITask/EditTask", ReplyAction="http://tempuri.org/ITask/EditTaskResponse")]
        System.Threading.Tasks.Task EditTaskAsync(Controldeaplicaciones_TODOLIST.ServiceReferenceTask.Task task);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ITask/ChangeStatusTask", ReplyAction="http://tempuri.org/ITask/ChangeStatusTaskResponse")]
        void ChangeStatusTask(int id);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ITask/ChangeStatusTask", ReplyAction="http://tempuri.org/ITask/ChangeStatusTaskResponse")]
        System.Threading.Tasks.Task ChangeStatusTaskAsync(int id);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ITask/DeleteTask", ReplyAction="http://tempuri.org/ITask/DeleteTaskResponse")]
        void DeleteTask(int id);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ITask/DeleteTask", ReplyAction="http://tempuri.org/ITask/DeleteTaskResponse")]
        System.Threading.Tasks.Task DeleteTaskAsync(int id);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface ITaskChannel : Controldeaplicaciones_TODOLIST.ServiceReferenceTask.ITask, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class TaskClient : System.ServiceModel.ClientBase<Controldeaplicaciones_TODOLIST.ServiceReferenceTask.ITask>, Controldeaplicaciones_TODOLIST.ServiceReferenceTask.ITask {
        
        public TaskClient() {
        }
        
        public TaskClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public TaskClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public TaskClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public TaskClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public Controldeaplicaciones_TODOLIST.ServiceReferenceTask.Task[] GetTasks() {
            return base.Channel.GetTasks();
        }
        
        public System.Threading.Tasks.Task<Controldeaplicaciones_TODOLIST.ServiceReferenceTask.Task[]> GetTasksAsync() {
            return base.Channel.GetTasksAsync();
        }
        
        public Controldeaplicaciones_TODOLIST.ServiceReferenceTask.Task[] ListPriority(string filtro) {
            return base.Channel.ListPriority(filtro);
        }
        
        public System.Threading.Tasks.Task<Controldeaplicaciones_TODOLIST.ServiceReferenceTask.Task[]> ListPriorityAsync(string filtro) {
            return base.Channel.ListPriorityAsync(filtro);
        }
        
        public Controldeaplicaciones_TODOLIST.ServiceReferenceTask.Task[] ListId(int id) {
            return base.Channel.ListId(id);
        }
        
        public System.Threading.Tasks.Task<Controldeaplicaciones_TODOLIST.ServiceReferenceTask.Task[]> ListIdAsync(int id) {
            return base.Channel.ListIdAsync(id);
        }
        
        public void InsertTask(Controldeaplicaciones_TODOLIST.ServiceReferenceTask.Task task) {
            base.Channel.InsertTask(task);
        }
        
        public System.Threading.Tasks.Task InsertTaskAsync(Controldeaplicaciones_TODOLIST.ServiceReferenceTask.Task task) {
            return base.Channel.InsertTaskAsync(task);
        }
        
        public void EditTask(Controldeaplicaciones_TODOLIST.ServiceReferenceTask.Task task) {
            base.Channel.EditTask(task);
        }
        
        public System.Threading.Tasks.Task EditTaskAsync(Controldeaplicaciones_TODOLIST.ServiceReferenceTask.Task task) {
            return base.Channel.EditTaskAsync(task);
        }
        
        public void ChangeStatusTask(int id) {
            base.Channel.ChangeStatusTask(id);
        }
        
        public System.Threading.Tasks.Task ChangeStatusTaskAsync(int id) {
            return base.Channel.ChangeStatusTaskAsync(id);
        }
        
        public void DeleteTask(int id) {
            base.Channel.DeleteTask(id);
        }
        
        public System.Threading.Tasks.Task DeleteTaskAsync(int id) {
            return base.Channel.DeleteTaskAsync(id);
        }

        internal void InsertTask(Models.Task task)
        {
            throw new NotImplementedException();
        }

        internal void EditTask(Models.Task task)
        {
            throw new NotImplementedException();
        }

        internal void EditTask(ITask itask)
        {
            throw new NotImplementedException();
        }

        internal void InsertTask(ITask itask)
        {
            throw new NotImplementedException();
        }
    }
}
