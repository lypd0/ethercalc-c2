<img width="128" height="128" alt="image" src="https://github.com/user-attachments/assets/e713a584-9986-4f3e-a869-6f9db818c390" />


# EtherCalc C2

A small C# proof-of-concept that uses a public EtherCalc spreadsheet as an intermediary communication channel.

This project is intended **only for educational purposes, security research, and authorized lab environments**.

## Overview

The current implementation is intentionally minimal.

At the moment, the agent only supports **remote command execution**: it retrieves a command from EtherCalc, executes it locally, and writes the output back to the spreadsheet.

```text
A1 = Command
A2 = Output
```

It is not intended to be a full-featured C2 framework in its current state.

However, the communication layer is already there, so the same approach could be extended into a more complete C2 design by adding things such as job handling, agent identification, state management, and additional task types.

## Intermediary Domain

The main purpose of this project is experimenting with the use of a legitimate third-party domain as an intermediary.

Rather than requiring the agent to connect directly to dedicated operator infrastructure, traffic is sent to `ethercalc.net` over HTTPS.

This makes the project useful for researching indirect C2 channels, legitimate-service abuse, and the defensive visibility associated with these techniques.

Using a legitimate domain does **not** make the channel undetectable. Endpoint telemetry, request patterns, process activity, and network behavior can still expose it.

## Encoding / Encryption

Communication can use either:

- Base64 encoding
- AES encryption

Base64 is only an encoding option and provides no confidentiality.

When encryption is enabled, commands and command output are encrypted before being stored in EtherCalc.

## Demo

A short demonstration of the proof-of-concept is available here:

[YouTube - EtherCalc C2 Demo](https://youtu.be/7V8vUtU7qcE)

## Configuration

Relevant settings include:

```csharp
ETHERCALC_ID
ETHERCALC_SHEET
CHECKIN_DELAY
USE_ENCRYPTION
ENCRYPTION_KEY
```

## Limitations

This is intentionally a basic proof-of-concept.

There is no proper authentication, job management, agent registration, or resilient state handling. Public EtherCalc sheets can also be modified or deleted by anyone who discovers them.

The project depends entirely on the intermediary service and should not be considered production-ready C2 software.

## Disclaimer

This repository is provided strictly for **educational, defensive security, research, and authorized testing purposes**.

Do not use it on systems you do not own or have explicit permission to test.

EtherCalc is an independent third-party project and is not associated with this repository. Avoid abusing public EtherCalc infrastructure. For extensive testing, use a controlled or self-hosted environment.
