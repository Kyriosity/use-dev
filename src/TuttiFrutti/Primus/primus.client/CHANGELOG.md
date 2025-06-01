## Ts.React with C#.NET

The following tools were used to generate this project:
- create-vite

The following steps were used to generate this project:

+ Create react project with create-vite: `npm init --yes vite@latest primus.client -- --template=react-ts`.
+ Update `vite.config.ts` to set up proxying and certs.
+ Add `@type/node` for `vite.config.js` typing.
+ Update `App` component to fetch and display measurements .
+ Create project file (`primus.client.esproj`).
+ Create `launch.json` to enable debugging.
+ Add project to solution.
+ Update proxy endpoint to be the backend server endpoint.

// Tuning the project