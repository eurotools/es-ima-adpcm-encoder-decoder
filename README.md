[![License](https://img.shields.io/github/license/eurotools/ima-adpcm_encoder-decoder)](https://www.gnu.org/licenses/gpl-3.0.html)
[![Issues](https://img.shields.io/github/issues/eurotools/ima-adpcm_encoder-decoder)](https://github.com/eurotools/ima-adpcm_encoder-decoder/issues)
[![GitHub Release](https://img.shields.io/github/v/release/eurotools/ima-adpcm_encoder-decoder)](https://github.com/eurotools/ima-adpcm_encoder-decoder/releases/latest)

# IMA ADPCM Audio Tool
Welcome to the **IMA ADPCM Audio Tool**, a console-based utility developed by jmarti856 for encoding and decoding audio files using the IMA ADPCM format. This tool is specialized for mono audio files and is designed to handle 16-bit WAV files.

## Features
- Encode 16-bit PCM WAV files into the IMA ADPCM format.
- Decode IMA ADPCM files back to the 16-bit PCM WAV format.
- Tailored for processing mono audio files.

## Compatibility Note
This tool is designed to work with headerless IMA ADPCM files. When decoding an IMA file, prior knowledge of the frequency and the number of channels is necessary to ensure accurate results during the decoding process.

## Download
To start using the IMA ADPCM Audio Tool, download the latest version from the link below:

[[![GitHub All Releases](https://img.shields.io/github/v/release/eurotools/ima-adpcm_encoder-decoder?style=for-the-badge)](https://github.com/eurotools/ima-adpcm_encoder-decoder/releases/latest)

## Usage

### Encoding
To encode a 16-bit PCM WAV file into IMA ADPCM format, use the following command:

```console
ImaAdpcmTool.exe <InputFile> <OutputFile>
```

```console
ImaAdpcmTool.exe "input.wav" "output.adpcm"
```

### Decoding
For decoding an IMA ADPCM file back to a 16-bit PCM WAV file, use the command:

```console
ImaAdpcmTool.exe <InputFile> <OutputFile> <Frequency>
```
Replace <Frequency> with the actual frequency value.

```
ImaAdpcmTool.exe Decode "input.adpcm" "output.wav" 44100
```