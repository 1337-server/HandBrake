﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace HandBrakeWPF.Properties {
    using System;
    
    
    /// <summary>
    ///   A strongly-typed resource class, for looking up localized strings, etc.
    /// </summary>
    // This class was auto-generated by the StronglyTypedResourceBuilder
    // class via a tool like ResGen or Visual Studio.
    // To add or remove a member, edit your .ResX file then rerun ResGen
    // with the /str option, or rebuild your VS project.
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Resources.Tools.StronglyTypedResourceBuilder", "16.0.0.0")]
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    public class ResourcesTooltips {
        
        private static global::System.Resources.ResourceManager resourceMan;
        
        private static global::System.Globalization.CultureInfo resourceCulture;
        
        [global::System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode")]
        internal ResourcesTooltips() {
        }
        
        /// <summary>
        ///   Returns the cached ResourceManager instance used by this class.
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        public static global::System.Resources.ResourceManager ResourceManager {
            get {
                if (object.ReferenceEquals(resourceMan, null)) {
                    global::System.Resources.ResourceManager temp = new global::System.Resources.ResourceManager("HandBrakeWPF.Properties.ResourcesTooltips", typeof(ResourcesTooltips).Assembly);
                    resourceMan = temp;
                }
                return resourceMan;
            }
        }
        
        /// <summary>
        ///   Overrides the current thread's CurrentUICulture property for all
        ///   resource lookups using this strongly typed resource class.
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        public static global::System.Globalization.CultureInfo Culture {
            get {
                return resourceCulture;
            }
            set {
                resourceCulture = value;
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Chroma Smooth Filter.
        /// </summary>
        public static string FiltersView_ChromaSmooth {
            get {
                return ResourceManager.GetString("FiltersView_ChromaSmooth", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Colourspace Filter..
        /// </summary>
        public static string FiltersView_ColourSpace {
            get {
                return ResourceManager.GetString("FiltersView_ColourSpace", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Custom Denoise parameters.
        /// 
        ///NLMeans syntax: y-strength=y:y-origin-tune=y:y-patch-size=y:y-range=y:y-frame-count=y:y-prefilter=y:cb-strength=c:cb-origin-tune=c:cb-patch-size=c:cb-range=c:cb-frame-count=c:cb-prefilter=c:cr-strength=c:cr-origin-tune=c:cr-patch-size=c:cr-range=c:cr-frame-count=c:cr-prefilter=c:threads=t
        ///
        ///NLMeans default: y-strength=6:y-origin-tune=1:y-patch-size=7:y-range=3:y-frame-count=2:y-prefilter=0:cb-strength=6:cb-origin-tune=1:cb-patch-size=7:cb-range=3:cb-frame-count=2:cb-prefilter [rest of string was truncated]&quot;;.
        /// </summary>
        public static string FilterView_CustomDenoiseParams {
            get {
                return ResourceManager.GetString("FilterView_CustomDenoiseParams", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Custom Sharpen parameters.
        ///
        ///Unsharp syntax: y-strength=y:y-size=y:cb-strength=c:cb-size=c:cr-strength=c:cr-size=c
        ///
        ///Unsharp default: y-strength=0.25:y-size=7:cb-strength=0.25:cb-size=7
        ///
        ///Lapsharp syntax: y-strength=y:y-kernel=y:cb-strength=c:cb-kernel=c:cr-strength=c:cr-kernel=c
        ///
        ///Lapsharp default: y-strength=0.2:y-kernel=isolap:cb-strength=0.2:cb-kernel=isolap.
        /// </summary>
        public static string FilterView_CustomSharpenParams {
            get {
                return ResourceManager.GetString("FilterView_CustomSharpenParams", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Deblock reduces blocky artifacts caused by low quality video compression..
        /// </summary>
        public static string FilterView_Deblock {
            get {
                return ResourceManager.GetString("FilterView_Deblock", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Choose decomb or deinterlace filter options.
        ///
        ///The decomb filter selectively deinterlaces frames that appear to be interlaced.
        ///This will preserve quality in frames that are not interlaced.
        ///
        ///The classic deinterlace filter is applied to all frames.
        ///Frames that are not interlaced will suffer some quality degradation..
        /// </summary>
        public static string FilterView_DecombDeinterlace {
            get {
                return ResourceManager.GetString("FilterView_DecombDeinterlace", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Deinterlace removes comb artifacts from the picture.
        ///
        ///Yadif is a popular and fast deinterlacer.
        ///
        ///Decomb switches between multiple interpolation algorithms for speed and quality..
        /// </summary>
        public static string FilterView_Deinterlace {
            get {
                return ResourceManager.GetString("FilterView_Deinterlace", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Custom Deinterlace parameters.
        /// 
        /// Yadif syntax: mode=m:parity=p
        /// 
        /// Yadif default: mode=3
        /// 
        /// Decomb syntax: mode=m:magnitude-thresh=m:variance-thresh=v:laplacian-thresh=l:dilation-thresh=d:erosion-thresh=e:noise-thresh=n:search-distance=s:postproc=p:parity=p
        /// 
        /// Decomb default: mode=7.
        /// </summary>
        public static string FilterView_DeinterlaceCustom {
            get {
                return ResourceManager.GetString("FilterView_DeinterlaceCustom", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Deinterlace filter preset.
        ///
        ///Default is well balanced for speed and quality.
        ///
        ///Skip Spatial Check lets Yadif skip correcting certain avoidable artifacts for a slight speed boost.
        ///
        ///EEDI2 uses a slower, higher quality interpolation algorithm for Decomb. Useful for the most difficult sources.
        ///
        ///Bob attempts to better preserve motion for a slight penalty to perceived resolution..
        /// </summary>
        public static string FilterView_DeinterlacePreset {
            get {
                return ResourceManager.GetString("FilterView_DeinterlacePreset", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Denoise reduces or removes the appearance of noise and grain. This can improve compression efficiency and create higher quality video at smaller file sizes. 
        ///Overly strong Denoise settings may damage picture quality by discarding detail.
        ///         
        ///NLMeans is a high quality denoise filter with a cost to speed. Use where quality is more important than speed.
        ///         
        ///HQDN3D is an adaptive low-pass filter, faster than NLMeans but less effective at preserving fine detail..
        /// </summary>
        public static string FilterView_Denoise {
            get {
                return ResourceManager.GetString("FilterView_Denoise", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Denoise filter preset. Sets the strength of the filter..
        /// </summary>
        public static string FilterView_DenoisePreset {
            get {
                return ResourceManager.GetString("FilterView_DenoisePreset", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Denoise tune. Further adjusts the Denoise preset to optimize settings for specific scenarios.
        /// 
        ///- None uses the default preset settings.
        /// 
        ///- Film refines settings for use with most live action content.
        /// 
        ///- Grain only processes color channels. Useful for preserving the film-like look of luminance grain while reducing or removing color noise.
        ///
        ///- High Motion reduces color smearing in high motion scenes by avoiding temporal processing for color channels. Useful for sports and action videos.
        ///
        ///- Animati [rest of string was truncated]&quot;;.
        /// </summary>
        public static string FilterView_DenoiseTune {
            get {
                return ResourceManager.GetString("FilterView_DenoiseTune", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Detelecine removes comb artifacts that are the result of telecine, a process for converting film frame rates to television frame rates..
        /// </summary>
        public static string FilterView_Detelecine {
            get {
                return ResourceManager.GetString("FilterView_Detelecine", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Flips (mirrors) the picture on the horizontal axis..
        /// </summary>
        public static string FilterView_Flip {
            get {
                return ResourceManager.GetString("FilterView_Flip", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Grayscale removes the color component of the video. Often referred to as Black &amp;amp; White video..
        /// </summary>
        public static string FilterView_Grayscale {
            get {
                return ResourceManager.GetString("FilterView_Grayscale", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Interlace Detection, when enabled, allows the Deinterlace filter to only process interlaced video frames..
        /// </summary>
        public static string FilterView_InterlaceDetection {
            get {
                return ResourceManager.GetString("FilterView_InterlaceDetection", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Custom Interlace Detection parameters.
        /// 
        /// Syntax: mode=m:spatial-metric=s:motion-thresh=m:spatial-thresh=s:filter-mode=f:block-thresh=b:block-width=b:block-height=b:disable=d
        /// 
        /// Default: mode=3:spatial-metric=2:motion-thresh=1:spatial-thresh=1:filter-mode=2:block-thresh=40:block-width=16:block-height=16.
        /// </summary>
        public static string FilterView_InterlaceDetectionCustom {
            get {
                return ResourceManager.GetString("FilterView_InterlaceDetectionCustom", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Rotate the picture clockwise in 90 degree increments..
        /// </summary>
        public static string FilterView_Rotate {
            get {
                return ResourceManager.GetString("FilterView_Rotate", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Sharpening enhances the appearance of detail, especially edges. Overly strong Sharpen settings may damage picture quality by creating ringing artifacts and enhancing noise, which can reduce compression efficiency.
        ///
        ///Unsharp is a general purpose unsharp masking filter. It sharpens by blurring, then calculating the difference between the blurred picture and the original.
        ///
        ///Lapsharp sharpens using convolution kernels approximating Laplacian edge filters, sometimes producing higher quality results than unshar [rest of string was truncated]&quot;;.
        /// </summary>
        public static string FilterView_Sharpen {
            get {
                return ResourceManager.GetString("FilterView_Sharpen", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Sharpen filter preset. Sets the strength of the filter..
        /// </summary>
        public static string FilterView_SharpenPreset {
            get {
                return ResourceManager.GetString("FilterView_SharpenPreset", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Sharpen tune. Further adjusts the Sharpen preset to optimize settings for specific scenarios.
        ///
        ///None uses the default preset settings.
        ///
        ///Unsharp can be tuned for Ultrafine, Fine, Medium, Coarse, or Very Coarse sharpening. Select one based on the output picture resolution and fineness of detail to enhance.
        ///
        ///Lapsharp&apos;s Film tune refines settings for use with most live action content. Film uses an isotropic Laplacian kernel to sharpen all edges similarly, and luminance (brightness) information is sharpened [rest of string was truncated]&quot;;.
        /// </summary>
        public static string FilterView_SharpenTune {
            get {
                return ResourceManager.GetString("FilterView_SharpenTune", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Add a new preset..
        /// </summary>
        public static string MainView_AddPreset {
            get {
                return ResourceManager.GetString("MainView_AddPreset", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Aligns the initial timestamps of all audio and video streams by inserting blank frames or dropping frames. May improve audio/video sync for broken players that do not honor MP4 edit lists..
        /// </summary>
        public static string MainView_AlignAVStart {
            get {
                return ResourceManager.GetString("MainView_AlignAVStart", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Video angle to encode. Only applicable to multi-angle DVD and Blu-ray..
        /// </summary>
        public static string MainView_Angle {
            get {
                return ResourceManager.GetString("MainView_Angle", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Browse to select a new destination path and file name for your encode..
        /// </summary>
        public static string MainView_Browse {
            get {
                return ResourceManager.GetString("MainView_Browse", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Destination path, including directory and file name. This is where your new video will be created, and what it will be named..
        /// </summary>
        public static string MainView_Destination {
            get {
                return ResourceManager.GetString("MainView_Destination", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Duration of the selected source range in Hours:Minutes:Seconds.
        /// </summary>
        public static string MainView_Duration {
            get {
                return ResourceManager.GetString("MainView_Duration", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The end point for this range..
        /// </summary>
        public static string MainView_EndPoint {
            get {
                return ResourceManager.GetString("MainView_EndPoint", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Add a special MP4 marker to allow playback on vintage iPod 5th Generation devices circa 2006. Other settings may affect compatibility..
        /// </summary>
        public static string MainView_IpodAtom {
            get {
                return ResourceManager.GetString("MainView_IpodAtom", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Container format. Video, audio, and other tracks are combined into a single file of this type. Affects compatibility..
        /// </summary>
        public static string MainView_Mux {
            get {
                return ResourceManager.GetString("MainView_Mux", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Optimize MP4 for progressive download. After encoding, data is reorganized and rewritten to allow immediate playback over a network, without needing to download the entire file..
        /// </summary>
        public static string MainView_Optimise {
            get {
                return ResourceManager.GetString("MainView_Optimise", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Additional Preset Options..
        /// </summary>
        public static string MainView_PresetAdditionalOptions {
            get {
                return ResourceManager.GetString("MainView_PresetAdditionalOptions", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Options to control presets..
        /// </summary>
        public static string MainView_PresetOptionsContextMenu {
            get {
                return ResourceManager.GetString("MainView_PresetOptionsContextMenu", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Presets are groups of encode settings tailored for specific scenarios. Select the one closest matching your intent.
        /// 
        /// Overrides all encode settings. Settings may be further adjusted after selecting a preset..
        /// </summary>
        public static string MainView_Presets {
            get {
                return ResourceManager.GetString("MainView_Presets", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Source range selection. By default, all chapters are selected and the entire source is encoded..
        /// </summary>
        public static string MainView_Range {
            get {
                return ResourceManager.GetString("MainView_Range", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Remove the selected preset..
        /// </summary>
        public static string MainView_RemovePreset {
            get {
                return ResourceManager.GetString("MainView_RemovePreset", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The start point for this range..
        /// </summary>
        public static string MainView_StartPoint {
            get {
                return ResourceManager.GetString("MainView_StartPoint", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Title, or video clip, to encode.
        ///Blu-ray and DVD sources often have multiple titles, the longest of which is typically the main feature.
        /// </summary>
        public static string MainView_Title {
            get {
                return ResourceManager.GetString("MainView_Title", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to When HandBrake has finished the current queue or encode it will perform this action..
        /// </summary>
        public static string MainView_WhenDone {
            get {
                return ResourceManager.GetString("MainView_WhenDone", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to When enabled the auto name system will always use the default path. 
        ///When disabled, it will use the path in the destination box on the main window if populated, otherwise it will use the default path..
        /// </summary>
        public static string OptionsView_AlwaysUseDefaultPath {
            get {
                return ResourceManager.GetString("OptionsView_AlwaysUseDefaultPath", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Anamorphic allows arbitrary storage dimensions while preserving the original aspect during playback.
        ///
        ///None disables anamorphic. Video storage dimensions and display dimensions will be identical. Only useful for compatibility with certain legacy devices.
        ///
        ///Automatic maximizes storage resolution while preserving the original display aspect ratio. Recommended.
        ///
        ///Loose is similar to Auto, but attempts to preserve the storage aspect ratio. This can result in a slight storage resolution loss compared to Auto. [rest of string was truncated]&quot;;.
        /// </summary>
        public static string PictureSettingsView_Anamorphic {
            get {
                return ResourceManager.GetString("PictureSettingsView_Anamorphic", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Automatically crop black borders around edges of the video..
        /// </summary>
        public static string PictureSettingsView_AutoCrop {
            get {
                return ResourceManager.GetString("PictureSettingsView_AutoCrop", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Crop the video from the bottom..
        /// </summary>
        public static string PictureSettingsView_CropBottom {
            get {
                return ResourceManager.GetString("PictureSettingsView_CropBottom", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Crop the video from the left side..
        /// </summary>
        public static string PictureSettingsView_CropLeft {
            get {
                return ResourceManager.GetString("PictureSettingsView_CropLeft", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Crop the video from the right side..
        /// </summary>
        public static string PictureSettingsView_CropRight {
            get {
                return ResourceManager.GetString("PictureSettingsView_CropRight", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Crop the video from the top..
        /// </summary>
        public static string PictureSettingsView_CropTop {
            get {
                return ResourceManager.GetString("PictureSettingsView_CropTop", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to This is the height that the video will be stored at.
        ///The actual display dimensions will differ if the pixel aspect ratio is not 1:1..
        /// </summary>
        public static string PictureSettingsView_Height {
            get {
                return ResourceManager.GetString("PictureSettingsView_Height", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Keep Aspect Ratio maintains the original display aspect of the source. Disabling this may result in a stretched or squeezed picture..
        /// </summary>
        public static string PictureSettingsView_KeepAR {
            get {
                return ResourceManager.GetString("PictureSettingsView_KeepAR", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Manually crop the video..
        /// </summary>
        public static string PictureSettingsView_ManualCrop {
            get {
                return ResourceManager.GetString("PictureSettingsView_ManualCrop", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Align storage dimensions to multiples of this value.
        ///
        ///This setting is only necessary for compatibility with some devices.
        ///You should use 2 unless you experience compatibility issues..
        /// </summary>
        public static string PictureSettingsView_Modulus {
            get {
                return ResourceManager.GetString("PictureSettingsView_Modulus", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to This field can accept RGB values such as: &quot;0xFF0000&quot; or colour names such as &quot;red&quot;. For a full list of named colours, see the padding filter documentation. .
        /// </summary>
        public static string PictureSettingsView_PaddingCustomColourTooltip {
            get {
                return ResourceManager.GetString("PictureSettingsView_PaddingCustomColourTooltip", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Pixel aspect defines the shape of the pixels.
        ///A 1:1 ratio defines a square pixel.  Other values define rectangular shapes.
        ///Players will scale the image in order to achieve the specified aspect..
        /// </summary>
        public static string PictureSettingsView_PAR {
            get {
                return ResourceManager.GetString("PictureSettingsView_PAR", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to This is the width that the video will be stored at.
        ///The actual display dimensions will differ if the pixel aspect ratio is not 1:1..
        /// </summary>
        public static string PictureSettingsView_Width {
            get {
                return ResourceManager.GetString("PictureSettingsView_Width", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Delete the job from the queue..
        /// </summary>
        public static string QueueView_DeleteJob {
            get {
                return ResourceManager.GetString("QueueView_DeleteJob", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Reset job status to Waiting..
        /// </summary>
        public static string QueueView_ResetJobStatus {
            get {
                return ResourceManager.GetString("QueueView_ResetJobStatus", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Send the job back to the main window for editing..
        /// </summary>
        public static string QueueView_SendJobBack {
            get {
                return ResourceManager.GetString("QueueView_SendJobBack", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Scan only the specified title instead of all titles..
        /// </summary>
        public static string SourceSelection_TitleSpecific {
            get {
                return ResourceManager.GetString("SourceSelection_TitleSpecific", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Set the average bitrate.
        ///
        ///The instantaneous bitrate can be much higher or lower at any point in time.
        ///But the average over a long duration will be the value set here.  If you need
        ///to limit instantaneous bitrate, look into x264&apos;s vbv-bufsize and vbv-maxrate settings..
        /// </summary>
        public static string Video_AvgBitrate {
            get {
                return ResourceManager.GetString("Video_AvgBitrate", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Enables constant framerate output..
        /// </summary>
        public static string Video_ConstantFramerate {
            get {
                return ResourceManager.GetString("Video_ConstantFramerate", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Available video encoders..
        /// </summary>
        public static string Video_Encoders {
            get {
                return ResourceManager.GetString("Video_Encoders", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Tune settings to optimize for common scenarios.
        ///
        ///This can improve efficiency for particular source characteristics or set
        ///characteristics of the output file.  Changes will be applied after the
        ///preset but before all other parameters..
        /// </summary>
        public static string Video_EncoderTune {
            get {
                return ResourceManager.GetString("Video_EncoderTune", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Additional encoder settings.
        ///
        ///Colon separated list of encoder options..
        /// </summary>
        public static string Video_ExtraOpts {
            get {
                return ResourceManager.GetString("Video_ExtraOpts", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Reduce decoder CPU usage.
        ///
        ///Set this if your device is struggling to play the output (dropped frames)..
        /// </summary>
        public static string Video_FastDecode {
            get {
                return ResourceManager.GetString("Video_FastDecode", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Output framerate.
        ///
        ///&apos;Same as source&apos; is recommended. If your source video has a variable framerate, &apos;Same as source&apos; will preserve it..
        /// </summary>
        public static string Video_Framerate {
            get {
                return ResourceManager.GetString("Video_Framerate", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Sets and ensures compliance with the specified level.
        ///
        ///Overrides all other settings..
        /// </summary>
        public static string Video_Level {
            get {
                return ResourceManager.GetString("Video_Level", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Enables variable framerate output with a peak rate determined by the framerate setting..
        /// </summary>
        public static string Video_PeakFramerate {
            get {
                return ResourceManager.GetString("Video_PeakFramerate", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Adjusts encoder settings to trade off compression efficiency against encoding speed.
        ///
        ///This establishes your default encoder settings.
        ///Tunes, profiles, levels and advanced option string will be applied to this.
        ///You should generally set this option to the slowest you can bear since slower
        ///settings will result in better quality or smaller files..
        /// </summary>
        public static string Video_Presets {
            get {
                return ResourceManager.GetString("Video_Presets", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Sets and ensures compliance with the specified profile.
        ///
        ///Overrides all other settings..
        /// </summary>
        public static string Video_Profile {
            get {
                return ResourceManager.GetString("Video_Profile", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Set the desired quality factor.
        ///The encoder targets a certain quality.
        ///The scale used by each video encoder is different.
        ///
        ///x264&apos;s scale is logarithmic and lower values correspond to higher quality.
        ///So small decreases in value will result in progressively larger increases
        ///in the resulting file size.  A value of 0 means lossless and will result
        ///in a file size that is larger than the original source, unless the source
        ///was also lossless.
        ///Suggested values are: 18 to 20 for standard definition sources an [rest of string was truncated]&quot;;.
        /// </summary>
        public static string Video_Quality {
            get {
                return ResourceManager.GetString("Video_Quality", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to During the 1st pass of a 2 pass encode, use settings that speed things along..
        /// </summary>
        public static string Video_TurboFirstPass {
            get {
                return ResourceManager.GetString("Video_TurboFirstPass", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Perform 2 Pass Encoding.
        ///
        ///The &apos;Bitrate&apos; option is prerequisite. During the 1st pass, statistics about
        ///the video are collected.  Then in the second pass, those statistics are used
        ///to make bitrate allocation decisions..
        /// </summary>
        public static string Video_TwoPass {
            get {
                return ResourceManager.GetString("Video_TwoPass", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Enables variable framerate output.
        ///
        ///VFR is not compatible with some players..
        /// </summary>
        public static string Video_VariableFramerate {
            get {
                return ResourceManager.GetString("Video_VariableFramerate", resourceCulture);
            }
        }
    }
}
