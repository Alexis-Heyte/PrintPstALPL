//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace PrintPostBureau.Views
{
#nullable disable

	[global::System.CodeDom.Compiler.GeneratedCode("CompiledBindings", null)]
	partial class SearchPage
	{
		private bool _generatedCodeInitialized;

		private void InitializeAfterConstructor()
		{
			if (_generatedCodeInitialized)
				return;

			_generatedCodeInitialized = true;



			this.BindingContextChanged += this_BindingContextChanged;
			if (this.BindingContext is global::PrintPostBureau.ViewModels.SearchViewModel dataRoot0)
			{
				Bindings_this.Initialize(this, dataRoot0);
			}
		}

		private void this_BindingContextChanged(object sender, global::System.EventArgs e)
		{
			Bindings_this.Cleanup();
			if (((global::Microsoft.Maui.Controls.Element)sender).BindingContext is global::PrintPostBureau.ViewModels.SearchViewModel dataRoot)
			{
				Bindings_this.Initialize(this, dataRoot);
			}
		}

		SearchPage_Bindings_this Bindings_this = new SearchPage_Bindings_this();

		class SearchPage_Bindings_this
		{
			SearchPage _targetRoot;
			global::PrintPostBureau.ViewModels.SearchViewModel _dataRoot;
			SearchPage_BindingsTrackings_this _bindingsTrackings;

			public void Initialize(SearchPage targetRoot, global::PrintPostBureau.ViewModels.SearchViewModel dataRoot)
			{
				_targetRoot = targetRoot;
				_dataRoot = dataRoot;
				_bindingsTrackings = new SearchPage_BindingsTrackings_this(this);

				Update();

				_bindingsTrackings.SetPropertyChangedEventHandler0(dataRoot);
			}

			public void Cleanup()
			{
				if (_targetRoot != null)
				{
					_bindingsTrackings.Cleanup();
					_dataRoot = null;
					_targetRoot = null;
				}
			}

			public void Update()
			{
				var dataRoot = _dataRoot;
				Update0_Title(dataRoot);
			}

			private void Update0_Title(global::PrintPostBureau.ViewModels.SearchViewModel value)
			{
#line (10, 5) - (10, 26) 10 "..\..\..\..\..\Views\SearchPage.xaml"
				_targetRoot.Title = value.Title;
#line default
			}

			class SearchPage_BindingsTrackings_this
			{
				global::System.WeakReference _bindingsWeakRef;
				global::System.ComponentModel.INotifyPropertyChanged _propertyChangeSource0;

				public SearchPage_BindingsTrackings_this(SearchPage_Bindings_this bindings)
				{
					_bindingsWeakRef = new global::System.WeakReference(bindings);
				}

				public void Cleanup()
				{
					SetPropertyChangedEventHandler0(null);
				}

				public void SetPropertyChangedEventHandler0(global::PrintPostBureau.ViewModels.SearchViewModel value)
				{
					global::CompiledBindings.MAUI.CompiledBindingsHelper.SetPropertyChangedEventHandler(ref _propertyChangeSource0, value, OnPropertyChanged0);
				}

				private void OnPropertyChanged0(object sender, global::System.ComponentModel.PropertyChangedEventArgs e)
				{
					var bindings = global::CompiledBindings.MAUI.CompiledBindingsHelper.TryGetBindings<SearchPage_Bindings_this>(ref _bindingsWeakRef, Cleanup);
					if (bindings == null)
					{
						return;
					}

					var typedSender = (global::PrintPostBureau.ViewModels.SearchViewModel)sender;
					if (string.IsNullOrEmpty(e.PropertyName) || e.PropertyName == "Title")
					{
						bindings.Update0_Title(typedSender);
					}
				}
			}
		}
	}
}
