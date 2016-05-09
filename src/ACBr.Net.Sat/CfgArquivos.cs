// ***********************************************************************
// Assembly         : ACBr.Net.Sat
// Author           : RFTD
// Created          : 03-31-2016
//
// Last Modified By : RFTD
// Last Modified On : 03-31-2016
// ***********************************************************************
// <copyright file="CfgArquivos.cs" company="ACBr.Net">
//     Copyright � ACBr.Net 2014 - 2016
// </copyright>
// <summary></summary>
// ***********************************************************************

using System.Reflection;
using ACBr.Net.Core.Extensions;

namespace ACBr.Net.Sat
{
	#region COM Interop Attributes

#if COM_INTEROP

	[ComVisible(true)]
    [Guid("3C5BA7DD-DB25-4919-AACC-E93E793F12E9")]
	[ClassInterface(ClassInterfaceType.AutoDual)]

#endif

	#endregion COM Interop Attributes
	/// <summary>
	/// Classe de configura��o de salvamento dos arquivos da NFe
	/// </summary>
	public sealed class CfgArquivos
	{
		#region Constructor

		/// <summary>
		/// Inicializa uma nova instancia da classe <see cref="CfgArquivos" />.
		/// </summary>
		internal CfgArquivos()
		{
			PrefixoArqCFe = @"AD";
			PrefixoArqCFeCanc = @"ADC";
			var path = Assembly.GetEntryAssembly().GetPath();
			PastaCFeVenda = $@"{path}\Vendas";
			PastaCFeCancelamento = $@"{path}\Cancelamentos";
			PastaEnvio = $@"{path}\Enviado";
		}

		#endregion Constructor

		#region Properties

		/// <summary>
		/// Gets or sets a value indicating whether [salvar c fe].
		/// </summary>
		/// <value><c>true</c> if [salvar c fe]; otherwise, <c>false</c>.</value>
		public bool SalvarCFe { get; set; }
		/// <summary>
		/// Gets or sets a value indicating whether [salvar c fe canc].
		/// </summary>
		/// <value><c>true</c> if [salvar c fe canc]; otherwise, <c>false</c>.</value>
		public bool SalvarCFeCanc { get; set; }
		/// <summary>
		/// Gets or sets a value indicating whether [salvar envio].
		/// </summary>
		/// <value><c>true</c> if [salvar envio]; otherwise, <c>false</c>.</value>
		public bool SalvarEnvio { get; set; }
		/// <summary>
		/// Gets or sets a value indicating whether [separar por CNPJ].
		/// </summary>
		/// <value><c>true</c> if [separar por CNPJ]; otherwise, <c>false</c>.</value>
		public bool SepararPorCNPJ { get; set; }
		/// <summary>
		/// Gets or sets a value indicating whether [separar por mes].
		/// </summary>
		/// <value><c>true</c> if [separar por mes]; otherwise, <c>false</c>.</value>
		public bool SepararPorMes { get; set; }
		/// <summary>
		/// Gets or sets the pasta c fe venda.
		/// </summary>
		/// <value>The pasta c fe venda.</value>
		public string PastaCFeVenda { get; set; }
		/// <summary>
		/// Gets or sets the pasta c fe cancelamento.
		/// </summary>
		/// <value>The pasta c fe cancelamento.</value>
		public string PastaCFeCancelamento { get; set; }
		/// <summary>
		/// Gets or sets the pasta envio.
		/// </summary>
		/// <value>The pasta envio.</value>
		public string PastaEnvio { get; set; }
		/// <summary>
		/// Gets or sets the prefixo arq c fe.
		/// </summary>
		/// <value>The prefixo arq c fe.</value>
		public string PrefixoArqCFe { get; set; }
		/// <summary>
		/// Gets or sets the prefixo arq c fe canc.
		/// </summary>
		/// <value>The prefixo arq c fe canc.</value>
		public string PrefixoArqCFeCanc { get; set; }

		#endregion Properties

		#region Methods
		#endregion Methods
	}
}