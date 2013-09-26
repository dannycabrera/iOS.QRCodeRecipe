#include "monotouch/main.h"

extern void *mono_aot_module_iOSQRCodeRecipe_info;
extern void *mono_aot_module_monotouch_info;
extern void *mono_aot_module_mscorlib_info;

void monotouch_register_modules ()
{
	mono_aot_register_module (mono_aot_module_iOSQRCodeRecipe_info);
	mono_aot_register_module (mono_aot_module_monotouch_info);
	mono_aot_register_module (mono_aot_module_mscorlib_info);

}

void monotouch_register_assemblies ()
{
	monotouch_open_and_register ("monotouch.dll");

}

void monotouch_setup ()
{
	use_old_dynamic_registrar = TRUE;
	monotouch_create_classes ();
	monotouch_assembly_name = "iOSQRCodeRecipe.exe";
	mono_use_llvm = FALSE;
	monotouch_log_level = 0;
	monotouch_debug_mode = TRUE;
	monotouch_new_refcount = FALSE;
	monotouch_sgen = FALSE;
}

